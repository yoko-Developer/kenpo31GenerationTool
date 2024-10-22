using System;

/// <summary>
/// FI_JRK_0004.csvの各レコードを表すモデルクラス
/// </summary>
public class FI_JRK_0004Model
{
	/// <summary>
	/// 要求レコード番号を表すプロパティ
	/// </summary>
	public string RecordNumber { get; set; }

	/// <summary>
	/// 個人番号を表すプロパティ
	/// </summary>
	public string PersonalNumber { get; set; }

	/// <summary>
	/// 照会結果氏名を表すプロパティ
	/// </summary>
	public string Name { get; set; }

	/// <summary>
	/// 照会結果氏名かなを表すプロパティ
	/// </summary>
	public string KanaName { get; set; }

	/// <summary>
	/// 照会結果生年月日を表すプロパティ
	/// </summary>
	public string Birthdate { get; set; }

	/// <summary>
	/// 照会結果性別コードを表すプロパティ (1: 男, 2: 女)
	/// </summary>
	public string GenderCode { get; set; }

	/// <summary>
	/// 市町村コードを表すプロパティ（5桁）
	/// </summary>
	public string MunicipalityCode { get; set; }

	/// <summary>
	/// FI_JRK_0004Modelクラスのインスタンスを初期化します。
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
	/// <param name="municipalityCode">市町村コード（5桁）</param>
	public FI_JRK_0004Model(
		string recordNumber,
		string personalNumber,
		string name,
		string kanaName,
		string birthdate,
		string genderCode,
		string municipalityCode)
	{
		this.RecordNumber = recordNumber;
		this.PersonalNumber = personalNumber;
		this.Name = name;
		this.KanaName = kanaName;
		this.Birthdate = birthdate;
		this.GenderCode = genderCode;
		this.MunicipalityCode = municipalityCode;
	}
}
