using System;
using System.Runtime.Serialization;

// Token: 0x02001A7E RID: 6782
[eiz("PVAPP")]
[Serializable]
public sealed class bdm : els, ISerializable
{
	// Token: 0x06009348 RID: 37704 RVA: 0x003A1CE4 File Offset: 0x0039FEE4
	private bdm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009349 RID: 37705 RVA: 0x003A1CF0 File Offset: 0x0039FEF0
	public bdm() : base(bdm.a, "Психическое явление", ci8.b)
	{
		base.Duration = 0;
		base.Icon = "Status.PlayerVoidApparition";
		base.Stacking = axm.b;
		base.VisualEffects.Add(new ud(this, "Displacement"));
		base.VisualEffects.Add(new ud(this, "Stealth"));
	}

	// Token: 0x0600934A RID: 37706 RVA: 0x003A1D54 File Offset: 0x0039FF54
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/PlayerVoidApparition", new object[0]);
	}

	// Token: 0x04003885 RID: 14469
	public new static string a = "playerVoidApparition";
}
