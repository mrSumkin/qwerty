using System;
using System.Runtime.Serialization;

// Token: 0x0200190F RID: 6415
[eiz("OD")]
[elw(typeof(d48))]
[Serializable]
public sealed class x2 : dj3, ISerializable
{
	// Token: 0x06008836 RID: 34870 RVA: 0x003865EC File Offset: 0x003847EC
	private x2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 194)
		{
			this.a = A_0.GetInt32("OD:X");
			this.b = A_0.GetInt32("OD:U");
			if (ell.a() >= 678)
			{
				this.c = A_0.GetString("OD:J");
			}
		}
	}

	// Token: 0x06008837 RID: 34871 RVA: 0x00386660 File Offset: 0x00384860
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("OD:X", this.a);
		info.AddValue("OD:U", this.b);
		info.AddValue("OD:J", this.c);
	}

	// Token: 0x06008838 RID: 34872 RVA: 0x003866A8 File Offset: 0x003848A8
	public override string tv()
	{
		return "Диковинка";
	}

	// Token: 0x06008839 RID: 34873 RVA: 0x003866B0 File Offset: 0x003848B0
	public int c()
	{
		return this.b;
	}

	// Token: 0x0600883A RID: 34874 RVA: 0x003866B8 File Offset: 0x003848B8
	public new void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600883B RID: 34875 RVA: 0x003866C4 File Offset: 0x003848C4
	public new int a()
	{
		return this.a;
	}

	// Token: 0x0600883C RID: 34876 RVA: 0x003866CC File Offset: 0x003848CC
	public void b(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600883D RID: 34877 RVA: 0x003866D8 File Offset: 0x003848D8
	public string b()
	{
		return this.c;
	}

	// Token: 0x0600883E RID: 34878 RVA: 0x003866E0 File Offset: 0x003848E0
	public new void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600883F RID: 34879 RVA: 0x003866EC File Offset: 0x003848EC
	public x2()
	{
	}

	// Token: 0x06008840 RID: 34880 RVA: 0x00386704 File Offset: 0x00384904
	public override bk3 tw()
	{
		x2 x = new x2();
		this.ai7(x);
		return x;
	}

	// Token: 0x06008841 RID: 34881 RVA: 0x00386720 File Offset: 0x00384920
	protected override void ai7(bk3 A_0)
	{
		base.ai7(A_0);
		x2 x = (x2)A_0;
		x.a = this.a;
		x.b = this.b;
		x.c = this.c;
	}

	// Token: 0x0400366D RID: 13933
	private new int a = 1;

	// Token: 0x0400366E RID: 13934
	private int b = 1;

	// Token: 0x0400366F RID: 13935
	private string c;
}
