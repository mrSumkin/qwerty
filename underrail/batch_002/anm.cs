using System;
using System.Runtime.Serialization;

// Token: 0x020004DC RID: 1244
[eiz("PS01")]
[Serializable]
public sealed class anm : dnh, ISerializable
{
	// Token: 0x06002000 RID: 8192 RVA: 0x000AEB1C File Offset: 0x000ACD1C
	private anm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("PS01:I");
		this.b = A_0.GetString("PS01:P");
	}

	// Token: 0x06002001 RID: 8193 RVA: 0x000AEB48 File Offset: 0x000ACD48
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PS01:I", this.a);
		info.AddValue("PS01:P", this.b);
	}

	// Token: 0x06002002 RID: 8194 RVA: 0x000AEB74 File Offset: 0x000ACD74
	public bool b()
	{
		return this.a;
	}

	// Token: 0x06002003 RID: 8195 RVA: 0x000AEB7C File Offset: 0x000ACD7C
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002004 RID: 8196 RVA: 0x000AEB88 File Offset: 0x000ACD88
	public string a()
	{
		return this.b;
	}

	// Token: 0x06002005 RID: 8197 RVA: 0x000AEB90 File Offset: 0x000ACD90
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002006 RID: 8198 RVA: 0x000AEB9C File Offset: 0x000ACD9C
	public anm()
	{
	}

	// Token: 0x06002007 RID: 8199 RVA: 0x000AEBA8 File Offset: 0x000ACDA8
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			c3n c3n = dgk.a(this.b);
			if (c3n != null)
			{
				return serviceOrThrow.aqu().v().PsiAbilities.c(c3n) ^ this.a;
			}
		}
		return false;
	}

	// Token: 0x040013F5 RID: 5109
	private bool a;

	// Token: 0x040013F6 RID: 5110
	private string b;
}
