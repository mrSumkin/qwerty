using System;
using System.Runtime.Serialization;

// Token: 0x02001449 RID: 5193
[eiz("TSEXE")]
[Serializable]
public sealed class kt : b1z, ISerializable
{
	// Token: 0x060074C0 RID: 29888 RVA: 0x003180F8 File Offset: 0x003162F8
	private kt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("TSEXE:T", typeof(edx)) as edx);
	}

	// Token: 0x060074C1 RID: 29889 RVA: 0x00318124 File Offset: 0x00316324
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TSEXE:T", this.a);
	}

	// Token: 0x060074C2 RID: 29890 RVA: 0x00318140 File Offset: 0x00316340
	public kt(edx A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060074C3 RID: 29891 RVA: 0x00318150 File Offset: 0x00316350
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a == null || this.a.ao() == null || this.a.ao().Area == null)
		{
			return dc4.e;
		}
		boj.d(this.a.ao());
		return dc4.c;
	}

	// Token: 0x04002FB4 RID: 12212
	private new edx a;
}
