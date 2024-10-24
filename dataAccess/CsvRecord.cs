using System;

namespace kenpo31GenerationTool.csvHandling
{
	/// <summary>
	/// FI_JRK_0004.csv の各レコードを表すクラス
	/// </summary>
	public class CsvRecord
	{
		// 要求レコード番号
		public string RecordNumber { get; set; } = "";

		// 個人番号
		public string PersonalNumber { get; set; } = "";

		// 照会結果氏名
		public string Name { get; set; } = "";

		// 照会結果氏名かな
		public string KanaName { get; set; } = "";

		// 照会結果生年月日
		public string Birthdate { get; set; } = "";

		// 照会結果性別コード(1: 男, 2: 女)
		public string GenderCode { get; set; } = "";

		// 照会結果性別
		public string Gender { get; set; } = "";

		// 照会結果住所
		public string Address { get; set; } = "";

		// 市町村コード（5桁）
		public string MunicipalityCode { get; set; } = "";

		// 対象者識別情報
		public string Identifier { get; set; } = "";

		// 照会処理結果コード
		public string ProcessingResultCode { get; set; } = "";

		// 照会処理結果
		public string ProcessingResult { get; set; } = "";

		// 照会結果レコード数
		public string RecordCount { get; set; } = "";

		// 照会結果レコード連番
		public string RecordSequenceNumber { get; set; } = "";

		// 異動有無コード
		public string MovementCode { get; set; } = "";

		// 異動有無
		public string Movement { get; set; } = "";

		// 生存状況コード
		public string LifeStatusCode { get; set; } = "";

		// 生存状況
		public string LifeStatus { get; set; } = "";	

		// 変更状況コード	
		public string ChangeStatusCode { get; set; } = "";

		// 変更状況
		public string ChangeStatus { get; set; } = "";

		// 異動事由コード
		public string MovementReasonCode { get; set; } = "";

		// 異動事由
		public string MovementReason { get; set; } = "";

		// 異動年月日	
		public string MovementDate { get; set; } = "";

		// 照会結果氏名外字数
		public string NameGaijiCount { get; set; } = "";

		// 照会結果住所外字数
		public string AddressGaijiCount { get; set; } = "";

		// 不参加団体対象フラグ
		public string NonParticipantFlag { get; set; } = "";

		// 不参加団体対象要因
		public string NonParticipantReason { get; set; } = "";

		/// <summary>
		/// CsvRecordを文字列配列に変換するメソッド
		/// </summary>
		/// <returns>CsvRecordの各プロパティを含む文字列配列</returns>
		public string[] ToArray()
		{
			return new string[]
			{
				RecordNumber,
				PersonalNumber,
				Name,
				KanaName,
				Birthdate,
				GenderCode,
				Gender,
				Address,
				MunicipalityCode,
				Identifier,
				ProcessingResultCode,
				ProcessingResult,
				RecordCount,
				RecordSequenceNumber,
				MovementCode,
				Movement,
				LifeStatusCode,
				LifeStatus,
				ChangeStatusCode,
				ChangeStatus,
				MovementReasonCode,
				MovementReason,
				MovementDate,
				NameGaijiCount,
				AddressGaijiCount,
				NonParticipantFlag,
				NonParticipantReason
			};
		}
	}
}
