using System;
using System.Runtime.Serialization;

// Token: 0x020011D4 RID: 4564
[eiz("NMTX")]
[Serializable]
public sealed class a41 : ya, ISerializable
{
	// Token: 0x060061F0 RID: 25072 RVA: 0x002A7918 File Offset: 0x002A5B18
	private a41(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("NMTX:C");
	}

	// Token: 0x060061F1 RID: 25073 RVA: 0x002A7934 File Offset: 0x002A5B34
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("NMTX:C", this.a);
	}

	// Token: 0x170001DC RID: 476
	// (get) Token: 0x060061F2 RID: 25074 RVA: 0x002A7950 File Offset: 0x002A5B50
	// (set) Token: 0x060061F3 RID: 25075 RVA: 0x002A7958 File Offset: 0x002A5B58
	public string MarkerCode
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x060061F4 RID: 25076 RVA: 0x002A7964 File Offset: 0x002A5B64
	public a41()
	{
	}

	// Token: 0x04002992 RID: 10642
	private string a;
}
