using System;

/// <summary>
/// FI_JRK_0004.csvの各レコードを表すモデルクラス
/// </summary>
public class FI_JRK_0004Model
{
	// 要求レコード番号
	public string RecordNumber { get; set; }

	// 個人番号
	public string PersonalNumber { get; set; }

	// 照会結果氏名
	public string Name { get; set; }

	// 照会結果氏名かな
	public string KanaName { get; set; }

	// 照会結果生年月日
	public string Birthdate { get; set; }

	// 照会結果性別コード(1: 男, 2: 女)
	public string GenderCode { get; set; }

	// 照会結果性別
	public string Gender { get; set; }

	// 照会結果住所
	public string Address { get; set; }

	// 市町村コード（5桁）
	public string MunicipalityCode { get; set; }

	// 対象者識別情報
	public string Identifier { get; set; }

	// 照会処理結果コード
	public string ProcessingResultCode { get; set; }

	// 照会処理結果
	public string ProcessingResult { get; set; }

	// 照会結果レコード数
	public string RecordCount { get; set; }

	// 照会結果レコード連番
	public string RecordSequenceNumber { get; set; }

	// 異動有無コード
	public string MovementCode { get; set; }

	// 異動有無
	public string Movement { get; set; }

	// 生存状況コード
	public string LifeStatusCode { get; set; }

	// 生存状況
	public string LifeStatus { get; set; }

	// 変更状況コード	
	public string ChangeStatusCode { get; set; }

	// 変更状況
	public string ChangeStatus { get; set; }

	// 異動事由コード
	public string MovementReasonCode { get; set; }

	// 異動事由
	public string MovementReason { get; set; }

	// 異動年月日	
	public string MovementDate { get; set; }

	// 照会結果氏名外字数
	public string NameGaijiCount { get; set; }

	// 照会結果住所外字数
	public string AddressGaijiCount { get; set; }

	// 不参加団体対象フラグ
	public string NonParticipantFlag { get; set; }

	// 不参加団体対象要因
	public string NonParticipantReason { get; set; }

	/// <summary>
	/// FI_JRK_0004Modelクラスのインスタンスを初期化
	/// </summary>
	public FI_JRK_0004Model() { }

	/// <summary>
	/// 各プロパティに値をセットするためのコンストラクタ
	/// </summary>
	/// <param name="recordNumber">要求レコード番号</param>
	/// <param name="personalNumber">個人番号</param>
	/// <param name="name">照会結果氏名</param>
	/// <param name="kanaName">照会結果氏名かな</param>
	/// <param name="birthdate">照会結果生年月日</param>
	/// <param name="genderCode">照会結果性別コード (1: 男, 2: 女)</param>
	/// <param name="gender">照会結果性別</param>
	/// <param name="address">照会結果住所</param>
	/// <param name="municipalityCode">市町村コード（5桁）</param>
	/// <param name="identifier">対象者識別情報</param>
	/// <param name="processingResultCode">照会処理結果コード</param>
	/// <param name="processingResult">照会処理結果</param>
	/// <param name="recordCount">照会結果レコード数</param>
	/// <param name="recordSequenceNumber">照会結果レコード連番</param>
	/// <param name="movementCode">異動有無コード</param>
	/// <param name="movement">異動有無</param>
	/// <param name="lifeStatusCode">生存状況コード</param>
	/// <param name="lifeStatus">生存状況</param>
	/// <param name="changeStatusCode">変更状況コード</param>
	/// <param name="changeStatus">変更状況</param>
	/// <param name="movementReasonCode">異動事由コード</param>
	/// <param name="movementReason">異動事由</param>
	/// <param name="movementDate">異動年月日</param>
	/// <param name="nameGaijiCount">照会結果氏名外字数</param>
	/// <param name="addressGaijiCount">照会結果住所外字数</param>
	/// <param name="nonParticipantFlag">不参加団体対象フラグ</param>
	/// <param name="nonParticipantReason">不参加団体対象要因</param>
	public FI_JRK_0004Model(
		string recordNumber,
		string personalNumber,
		string name,
		string kanaName,
		string birthdate,
		string genderCode,
		string gender,
		string address,
		string municipalityCode,
		string identifier,
		string processingResultCode,
		string processingResult,
		string recordCount,
		string recordSequenceNumber,
		string movementCode,
		string movement,
		string lifeStatusCode,
		string lifeStatus,
		string changeStatusCode,
		string changeStatus,
		string movementReasonCode,
		string movementReason,
		string movementDate,
		string nameGaijiCount,
		string addressGaijiCount,
		string nonParticipantFlag,
		string nonParticipantReason)
	{
		this.RecordNumber = recordNumber;
		this.PersonalNumber = personalNumber;
		this.Name = name;
		this.KanaName = kanaName;
		this.Birthdate = birthdate;
		this.GenderCode = genderCode;
		this.Gender = gender;
		this.Address = address;
		this.MunicipalityCode = municipalityCode;
		this.Identifier = identifier;
		this.ProcessingResultCode = processingResultCode;
		this.ProcessingResult = processingResult;
		this.RecordCount = recordCount;
		this.RecordSequenceNumber = recordSequenceNumber;
		this.MovementCode = movementCode;
		this.Movement = movement;
		this.LifeStatusCode = lifeStatusCode;
		this.LifeStatus = lifeStatus;
		this.ChangeStatusCode = changeStatusCode;
		this.ChangeStatus = changeStatus;
		this.MovementReasonCode = movementReasonCode;
		this.MovementReason = movementReason;
		this.MovementDate = movementDate;
		this.NameGaijiCount = nameGaijiCount;
		this.AddressGaijiCount = addressGaijiCount;
		this.NonParticipantFlag = nonParticipantFlag;
		this.NonParticipantReason = nonParticipantReason;
	}
}
