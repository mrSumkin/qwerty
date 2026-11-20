using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x0200028E RID: 654
[eiz("NEET")]
[Serializable]
public sealed class np : dvv, ISerializable
{
	// Token: 0x0600131E RID: 4894 RVA: 0x0004F344 File Offset: 0x0004D544
	private np(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("NEET:T", typeof(edx)) as edx);
		this.b = (A_0.GetValue("NEET:E", typeof(ar7)) as ar7);
	}

	// Token: 0x0600131F RID: 4895 RVA: 0x0004F39C File Offset: 0x0004D59C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("NEET:T", this.a);
		info.AddValue("NEET:E", this.b);
	}

	// Token: 0x06001320 RID: 4896 RVA: 0x0004F3C8 File Offset: 0x0004D5C8
	public np(b0b A_0, ak1 A_1)
	{
		this.a = new edx(A_1);
		this.b = new ar7(A_0);
	}

	// Token: 0x06001321 RID: 4897 RVA: 0x0004F3E8 File Offset: 0x0004D5E8
	protected override dc4 dt()
	{
		return dc4.b;
	}

	// Token: 0x06001322 RID: 4898 RVA: 0x0004F3EC File Offset: 0x0004D5EC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.b.ao() == null || this.a.ao() == null)
		{
			return dc4.e;
		}
		if (this.b.ao().CanTrigger && this.a.ao().TriggerProxies != null)
		{
			foreach (bqt bqt in Enumerable.ToList<bqt>(this.a.ao().TriggerProxies))
			{
				bqt.b(this.a.ao(), this.b.ao());
			}
		}
		return dc4.c;
	}

	// Token: 0x04000A68 RID: 2664
	private new edx a;

	// Token: 0x04000A69 RID: 2665
	private ar7 b;
}
