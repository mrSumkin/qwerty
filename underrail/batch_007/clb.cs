using System;
using System.Runtime.Serialization;

// Token: 0x020004D8 RID: 1240
[eiz("PHF")]
[Serializable]
public sealed class clb : dnh, ISerializable
{
	// Token: 0x06001FDE RID: 8158 RVA: 0x000AE6A4 File Offset: 0x000AC8A4
	private clb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("PHF:F");
		if (ell.a() >= 474)
		{
			this.b = A_0.GetBoolean("PHF:I");
		}
	}

	// Token: 0x06001FDF RID: 8159 RVA: 0x000AE6E0 File Offset: 0x000AC8E0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PHF:F", this.a);
		info.AddValue("PHF:I", this.b);
	}

	// Token: 0x06001FE0 RID: 8160 RVA: 0x000AE70C File Offset: 0x000AC90C
	public string a()
	{
		return this.a;
	}

	// Token: 0x06001FE1 RID: 8161 RVA: 0x000AE714 File Offset: 0x000AC914
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001FE2 RID: 8162 RVA: 0x000AE720 File Offset: 0x000AC920
	public bool b()
	{
		return this.b;
	}

	// Token: 0x06001FE3 RID: 8163 RVA: 0x000AE728 File Offset: 0x000AC928
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001FE4 RID: 8164 RVA: 0x000AE734 File Offset: 0x000AC934
	public clb()
	{
	}

	// Token: 0x06001FE5 RID: 8165 RVA: 0x000AE740 File Offset: 0x000AC940
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			ai8 ai = ck.a(this.a);
			if (ai != null)
			{
				flag = serviceOrThrow.aqu().v().Feats.a(ai);
			}
		}
		return flag ^ this.b;
	}

	// Token: 0x040013EC RID: 5100
	private string a;

	// Token: 0x040013ED RID: 5101
	private bool b;
}
