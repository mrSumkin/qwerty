using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200129A RID: 4762
[eiz("JTHEA")]
[a(typeof(d8r))]
[Serializable]
public sealed class a2j : d8r, ISerializable
{
	// Token: 0x06006801 RID: 26625 RVA: 0x002C03E8 File Offset: 0x002BE5E8
	private a2j(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<cze>("JTHEA:J", ref this.a, A_0);
		this.b = A_0.GetInt32("JTHEA:M");
		this.c = A_0.GetInt32("JTHEA:E");
	}

	// Token: 0x06006802 RID: 26626 RVA: 0x002C0444 File Offset: 0x002BE644
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<cze>("JTHEA:J", this.a, info);
		info.AddValue("JTHEA:M", this.b);
		info.AddValue("JTHEA:E", this.c);
	}

	// Token: 0x06006803 RID: 26627 RVA: 0x002C0484 File Offset: 0x002BE684
	public List<cze> a()
	{
		return this.a;
	}

	// Token: 0x06006804 RID: 26628 RVA: 0x002C048C File Offset: 0x002BE68C
	public void a(List<cze> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006805 RID: 26629 RVA: 0x002C0498 File Offset: 0x002BE698
	public int b()
	{
		return this.b;
	}

	// Token: 0x06006806 RID: 26630 RVA: 0x002C04A0 File Offset: 0x002BE6A0
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006807 RID: 26631 RVA: 0x002C04AC File Offset: 0x002BE6AC
	public int d()
	{
		return this.c;
	}

	// Token: 0x06006808 RID: 26632 RVA: 0x002C04B4 File Offset: 0x002BE6B4
	public a2j(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006809 RID: 26633 RVA: 0x002C04D0 File Offset: 0x002BE6D0
	public override void tt(int A_0, bool A_1)
	{
		if (this.b <= 0 || this.c < this.b)
		{
			foreach (cze cze in this.a)
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary["execution"] = this.c;
				dictionary["gasLevel"] = A_0;
				dictionary["partial"] = A_1;
				cze.ym(base.a8(), base.a8(), dictionary);
			}
			this.c++;
		}
	}

	// Token: 0x04002AFB RID: 11003
	private List<cze> a = new List<cze>();

	// Token: 0x04002AFC RID: 11004
	private int b = 1;

	// Token: 0x04002AFD RID: 11005
	private int c;
}
