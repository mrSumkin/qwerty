using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200112C RID: 4396
[eiz("SRJ")]
[Serializable]
public sealed class pq : cze, ISerializable
{
	// Token: 0x06005E10 RID: 24080 RVA: 0x0027DAE8 File Offset: 0x0027BCE8
	private pq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<coh>("SRJ:L", ref this.a, A_0);
		this.b = A_0.GetString("SRJ:OLB");
		this.c = A_0.GetBoolean("SRJ:FI");
		if (ell.a() >= 85)
		{
			this.d = (A_0.GetValue("SRJ:C", typeof(ar7)) as ar7);
		}
	}

	// Token: 0x06005E11 RID: 24081 RVA: 0x0027DB5C File Offset: 0x0027BD5C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<coh>("SRJ:L", this.a, info);
		info.AddValue("SRJ:OLB", this.b);
		info.AddValue("SRJ:FI", this.c);
		info.AddValue("SRJ:C", this.d);
	}

	// Token: 0x06005E12 RID: 24082 RVA: 0x0027DBB8 File Offset: 0x0027BDB8
	public pq(List<coh> A_0, string A_1 = null, bool A_2 = true, ar7 A_3 = null)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
	}

	// Token: 0x06005E13 RID: 24083 RVA: 0x0027DBE0 File Offset: 0x0027BDE0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		amc aspect = A_1.GetAspect<amc>();
		if (aspect != null)
		{
			string a_;
			if (this.b != null)
			{
				a_ = this.b;
			}
			else
			{
				a_ = aspect.v();
			}
			et5.a(A_1, a_, this.a, this.c, true, false, (this.d != null) ? (this.d.ao() as c5x) : null);
		}
	}

	// Token: 0x04002569 RID: 9577
	private new List<coh> a;

	// Token: 0x0400256A RID: 9578
	private string b;

	// Token: 0x0400256B RID: 9579
	private bool c;

	// Token: 0x0400256C RID: 9580
	private ar7 d;
}
