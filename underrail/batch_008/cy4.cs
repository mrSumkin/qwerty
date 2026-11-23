using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020012AE RID: 4782
[a(typeof(crb))]
[eiz("JTNREA")]
[Serializable]
public sealed class cy4 : crb, ISerializable
{
	// Token: 0x060068E5 RID: 26853 RVA: 0x002C50B8 File Offset: 0x002C32B8
	private cy4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<cze>("JTNREA:J", ref this.a, A_0);
		this.b = A_0.GetInt32("JTNREA:M");
		this.c = A_0.GetInt32("JTNREA:E");
	}

	// Token: 0x060068E6 RID: 26854 RVA: 0x002C5114 File Offset: 0x002C3314
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<cze>("JTNREA:J", this.a, info);
		info.AddValue("JTNREA:M", this.b);
		info.AddValue("JTNREA:E", this.c);
	}

	// Token: 0x060068E7 RID: 26855 RVA: 0x002C5154 File Offset: 0x002C3354
	public List<cze> b()
	{
		return this.a;
	}

	// Token: 0x060068E8 RID: 26856 RVA: 0x002C515C File Offset: 0x002C335C
	public new void a(List<cze> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060068E9 RID: 26857 RVA: 0x002C5168 File Offset: 0x002C3368
	public new int a()
	{
		return this.b;
	}

	// Token: 0x060068EA RID: 26858 RVA: 0x002C5170 File Offset: 0x002C3370
	public new void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060068EB RID: 26859 RVA: 0x002C517C File Offset: 0x002C337C
	public int d()
	{
		return this.c;
	}

	// Token: 0x060068EC RID: 26860 RVA: 0x002C5184 File Offset: 0x002C3384
	public cy4(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060068ED RID: 26861 RVA: 0x002C51A0 File Offset: 0x002C33A0
	protected override void aiq(ak1 A_0, double A_1)
	{
		if (this.b <= 0 || this.c < this.b)
		{
			foreach (cze cze in this.a)
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary["execution"] = this.c;
				cze.ym(base.a8(), base.a8(), dictionary);
			}
			this.c++;
		}
	}

	// Token: 0x04002B54 RID: 11092
	private new List<cze> a = new List<cze>();

	// Token: 0x04002B55 RID: 11093
	private int b = 1;

	// Token: 0x04002B56 RID: 11094
	private int c;
}
