using System;
using System.Runtime.Serialization;

// Token: 0x02001295 RID: 4757
[a(typeof(c5i))]
[eiz("SPCTOEA")]
[Serializable]
public sealed class e6n : c5i, ISerializable
{
	// Token: 0x060067E2 RID: 26594 RVA: 0x002BFF5C File Offset: 0x002BE15C
	private e6n(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("SPCTOEA:C");
	}

	// Token: 0x060067E3 RID: 26595 RVA: 0x002BFF78 File Offset: 0x002BE178
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SPCTOEA:C", this.a);
	}

	// Token: 0x060067E4 RID: 26596 RVA: 0x002BFF94 File Offset: 0x002BE194
	public string a()
	{
		return this.a;
	}

	// Token: 0x060067E5 RID: 26597 RVA: 0x002BFF9C File Offset: 0x002BE19C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060067E6 RID: 26598 RVA: 0x002BFFA8 File Offset: 0x002BE1A8
	public e6n(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060067E7 RID: 26599 RVA: 0x002BFFB4 File Offset: 0x002BE1B4
	public override string g1()
	{
		base.a8().Zone.ActionManager.g9(new c7(base.a8(), false, false, true, false), atp.a);
		return this.a;
	}

	// Token: 0x04002AF3 RID: 10995
	private string a;
}
