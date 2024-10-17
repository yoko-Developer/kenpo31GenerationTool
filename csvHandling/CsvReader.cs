using System;
using System.Collections.Generic;
using System.IO;

namespace kenpo31GenerationTool.csvHandling
{

	/// <summary>
	/// FI_JRK_0004.csvを読み込むクラス
	/// </summary>
	public class CsvReader
	{
		/// <summary>
		/// csvファイルを読み込むメソッド
		/// </summary>
		/// <param name="filePath">FI_JRK_0004.csvのパス</param>
		/// <returns>FI_JRK_0004.csvの内容をリストで返す</returns>
		public List<string[]> ReadCsv(string filePath)
		{
			List<string[]> records = new List<string[]>();

			try
			{
				// csvファイルを開く
				using (StreamReader sr = new StreamReader(filePath))
				{
					string line;

					// 1行ずつ読み込み
					while ((line = sr.ReadLine()) != null)
					{
						// 各行カンマで分割して配列にする
						string[] fields = line.Split(',');

						// 配列をリストに追加
						records.Add(fields);
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception($"csvファイルの読み込み中にエラーが発生しました: {ex.Message}");
			}

			return records;
		}

		/// <summary>
		/// csvファイルのヘッダ行チェックメソッド
		/// </summary>
		/// <param name="headers">読み込んだヘッダ</param>
		/// <param name="expectedHeaders">期待されるヘッダ</param>
		/// <returns>ヘッダが一致するか検証</returns>
		public bool ValidateHeaders(string[] headers, string[] expectedHeaders)
		{
			if (headers.Length != expectedHeaders.Length)
			{
				// ヘッダ数が一致しない
				return false;
			}

			for (int i = 0; i < headers.Length; i++)
			{
				if (headers[i].Trim() != expectedHeaders[i].Trim())
				{
					// ヘッダの内容が一致しない
					return false;
				}
			}
			// ヘッダが一致
			return true;

		}

		public bool ValidateRecord(string[] record)
		{

			// 1. 必須項目チェック
			if (string.IsNullOrEmpty(record[0])) return false; // 要求レコード番号
			if (string.IsNullOrEmpty(record[1])) return false; // 個人番号
			if (string.IsNullOrEmpty(record[2])) return false; // 照会結果氏名
			if (string.IsNullOrEmpty(record[3])) return false; // 照会結果氏名かな
			if (string.IsNullOrEmpty(record[4])) return false; // 照会結果生年月日
			if (string.IsNullOrEmpty(record[5])) return false; // 照会結果性別コード

			// 2. データ型と文字数チェック
			if (!IsValidDate(record[4])) return false; // 生年月日（YYYYMMDD形式）
			if (record[2].Length > 131) return false;  // 照会結果氏名（最大131文字）
			if (record[3].Length > 201) return false;  // 照会結果氏名かな（最大201文字）

			// 3. 市町村コードの（5桁）バリデーション
			if (string.IsNullOrEmpty(record[9]) || record[9].Length != 5) return false;

			// その他のバリデーションチェック性別コードが不正
			if (!IsValidGenderCode(record[5])) return false;

			// 全てのバリデーションを通過したらtrueを返す
			return true;
		}

		/// <summary>
		/// 性別コードのバリデーションチェック
		/// </summary>
		/// <param name="genderCode">性別コード</param>
		/// <returns>性別コードが正しければtrue、不正ならfalse</returns>
		private bool IsValidGenderCode(string genderCode)
		{
			// 1: 男, 2: 女
			return genderCode == "1" || genderCode == "2";
		}

		/// <summary>
		/// 日付形式（YYYYMMDD形式）のバリデーションチェック
		/// </summary>
		/// <param name="date">日付文字列</param>
		/// <returns>正しい日付形式ならtrue、不正ならfalse</returns>
		private bool IsValidDate(string date)
		{
			if (date.Length != 8) return false;
			DateTime tempDate;
			return DateTime.TryParseExact(date, "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out tempDate);
		}
	}
}
