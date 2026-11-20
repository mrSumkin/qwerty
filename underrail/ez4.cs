using System;
using System.Runtime.Serialization;

// Token: 0x02000291 RID: 657
[eiz("S99")]
[Serializable]
public sealed class ez4 : dvv, ISerializable
{
	// Token: 0x06001344 RID: 4932 RVA: 0x00050984 File Offset: 0x0004EB84
	private ez4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("S99:Z", typeof(a55)) as a55);
		this.b = (atp)A_0.GetValue("S99:T", typeof(atp));
		this.c = (A_0.GetValue("S99:A", typeof(auv)) as auv);
	}

	// Token: 0x06001345 RID: 4933 RVA: 0x000509FC File Offset: 0x0004EBFC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("S99:Z", this.a);
		info.AddValue("S99:T", this.b);
		info.AddValue("S99:A", this.c);
	}

	// Token: 0x06001346 RID: 4934 RVA: 0x00050A4C File Offset: 0x0004EC4C
	public ez4(a55 A_0, auv A_1, atp A_2 = atp.a)
	{
		this.a = A_0;
		this.b = A_2;
		this.c = A_1;
	}

	// Token: 0x06001347 RID: 4935 RVA: 0x00050A6C File Offset: 0x0004EC6C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a != null && this.a.ao() != null && this.c != null)
		{
			this.a.ao().ActionManager.g9(this.c, this.b);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x04000A81 RID: 2689
	private new a55 a;

	// Token: 0x04000A82 RID: 2690
	private atp b;

	// Token: 0x04000A83 RID: 2691
	private auv c;
}
