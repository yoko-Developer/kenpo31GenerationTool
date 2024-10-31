using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
				// Shift_JISでcsvファイルを開く
				using (StreamReader sr = new StreamReader(filePath, Encoding.GetEncoding("shift_jis")))
				{
					string line;
					int row = 0;

					// 1行ずつ読み込み
					while ((line = sr.ReadLine()) != null)
					{

						// 各行カンマで分割
						string[] fields = line.Split(',');

						// CsvRecordオブジェクトを作成
						CsvRecord record = new CsvRecord
						{
							// 各フィールドをCsvRecordのプロパティにマップ
							RecordNumber = fields[0],
							PersonalNumber = fields[1],
							Name = fields[2],
							KanaName = fields[3],
							Birthdate = fields[4],
							GenderCode = fields[5],
							Gender = fields[6],
							Address = fields[7],
							Identifier = fields[8],
							MunicipalityCode = fields[9],
							ProcessingResultCode = fields[10],
							ProcessingResult = fields[11],
							RecordCount = fields[12],
							RecordSequenceNumber = fields[13],
							MovementCode = fields[14],
							Movement = fields[15],
							LifeStatusCode = fields[16],
							LifeStatus = fields[17],
							ChangeStatusCode = fields[18],
							ChangeStatus = fields[19],
							MovementReasonCode = fields[20],
							MovementReason = fields[21],
							MovementDate = fields[22],
							NameGaijiCount = fields[23],
							AddressGaijiCount = fields[24],
							NonParticipantFlag = fields[25],
							NonParticipantReason = fields[26]
						};

						// バリデーションチェック
						if (!ValidateRecord(fields))
						{
							// レコードをリストに追加
							records.Add(fields);
						}
						//else
						//{
						//	throw new Exception($"無効なレコードが見つかりました：{line}");
						//}

						row++;
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
		/// CsvRecordリストをstring[]リストに変換するメソッド
		/// </summary>
		/// <param name="csvRecords">CsvRecordのリスト</param>
		/// <returns>string[]のリスト</returns>
		public List<string[]> ConvertToStringArray(List<CsvRecord> csvRecords)
		{
			List<string[]> result = new List<string[]>();

			foreach (var record in csvRecords)
			{
				// CsvRecordのプロパティをstring[]に変換
				result.Add(new string[]
				{
					record.RecordNumber,
					record.PersonalNumber,
					record.Name,
					record.KanaName,
					record.Birthdate,
					record.GenderCode,
					record.Gender,
					record.Address,
					record.Identifier,
					record.MunicipalityCode,
					record.ProcessingResultCode,
					record.ProcessingResult,
					record.RecordCount,
					record.RecordSequenceNumber,
					record.MovementCode,
					record.Movement,
					record.LifeStatusCode,
					record.LifeStatus,
					record.ChangeStatusCode,
					record.ChangeStatus,
					record.MovementReasonCode,
					record.MovementReason,
					record.MovementDate,
					record.NameGaijiCount,
					record.AddressGaijiCount,
					record.NonParticipantFlag,
					record.NonParticipantReason
				});
			}

			return result;
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

		/// <summary>
		/// レコードのバリデーションチェック
		/// </summary>
		/// <param name="record">csvファイルのレコード</param>
		/// <returns>バリデーション結果</returns>

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

			// 4. 性別コードのバリデーション
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