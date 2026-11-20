using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x0200184C RID: 6220
[eiz("UEA2")]
[Serializable]
public sealed class a6p : Aspect<b0b>, bp1, ISerializable
{
	// Token: 0x06008487 RID: 33927 RVA: 0x00372420 File Offset: 0x00370620
	private a6p(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("UEA2:B");
			di7.ReadList<string>("UEA2:F", ref this.b, A_0);
			return;
		}
		this.a = A_0.GetString("_Blueprint");
		this.b = new List<string>();
		di7.ReadList<string>("_Flags", ref this.b, A_0);
	}

	// Token: 0x06008488 RID: 33928 RVA: 0x0037249C File Offset: 0x0037069C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("UEA2:B", this.a);
		di7.WriteList<string>("UEA2:F", this.b, info);
	}

	// Token: 0x06008489 RID: 33929 RVA: 0x003724C8 File Offset: 0x003706C8
	public string b()
	{
		return this.a;
	}

	// Token: 0x0600848A RID: 33930 RVA: 0x003724D0 File Offset: 0x003706D0
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600848B RID: 33931 RVA: 0x003724DC File Offset: 0x003706DC
	public List<string> d()
	{
		return this.b;
	}

	// Token: 0x0600848C RID: 33932 RVA: 0x003724E4 File Offset: 0x003706E4
	public void a(List<string> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600848D RID: 33933 RVA: 0x003724F0 File Offset: 0x003706F0
	public a6p(b0b A_0) : base(A_0)
	{
	}

	// Token: 0x0600848E RID: 33934 RVA: 0x00372504 File Offset: 0x00370704
	public void mx()
	{
		this.a();
	}

	// Token: 0x0600848F RID: 33935 RVA: 0x0037250C File Offset: 0x0037070C
	public void my()
	{
	}

	// Token: 0x06008490 RID: 33936 RVA: 0x00372510 File Offset: 0x00370710
	private void a()
	{
		if (!string.IsNullOrEmpty(this.a))
		{
			c5k c5k = bpo.GetService<d6j>().dv().a(this.a);
			if (c5k != null)
			{
				c5k.a(base.a8(), this.b);
			}
		}
	}

	// Token: 0x040032C4 RID: 12996
	private string a;

	// Token: 0x040032C5 RID: 12997
	private List<string> b = new List<string>();
}
