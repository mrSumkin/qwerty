using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x02001419 RID: 5145
[eiz("XCX")]
[Serializable]
public sealed class a0f : b1z, ISerializable
{
	// Token: 0x06007373 RID: 29555 RVA: 0x0030AA0C File Offset: 0x00308C0C
	private a0f(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("XCX:S", typeof(ar7)) as ar7);
		this.b = (A_0.GetValue("XCX:O", typeof(ap9)) as ap9);
		di7.ReadList<CombatSpeakEvent>("XCX:E", ref this.c, A_0);
	}

	// Token: 0x06007374 RID: 29556 RVA: 0x0030AA74 File Offset: 0x00308C74
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XCX:S", this.a);
		info.AddValue("XCX:O", this.b);
		di7.WriteList<CombatSpeakEvent>("XCX:E", this.c, info);
	}

	// Token: 0x06007375 RID: 29557 RVA: 0x0030AABC File Offset: 0x00308CBC
	public a0f(c5x A_0, ap9 A_1, CombatSpeakEvent[] A_2)
	{
		this.a = new ar7(A_0);
		this.b = A_1;
		this.c = new List<CombatSpeakEvent>(A_2);
	}

	// Token: 0x06007376 RID: 29558 RVA: 0x0030AAE4 File Offset: 0x00308CE4
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a != null && this.a.ao() != null && this.c.Count > 0)
		{
			a20.a(this.a.ao() as c5x, this.b, this.c.ToArray());
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x04002F34 RID: 12084
	private new ar7 a;

	// Token: 0x04002F35 RID: 12085
	private ap9 b;

	// Token: 0x04002F36 RID: 12086
	private List<CombatSpeakEvent> c;
}
