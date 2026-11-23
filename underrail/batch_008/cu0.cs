using System;
using System.Runtime.Serialization;

// Token: 0x02001AA3 RID: 6819
[eiz("BTSE")]
[Serializable]
public sealed class cu0 : els, ISerializable
{
	// Token: 0x060093F7 RID: 37879 RVA: 0x003A4814 File Offset: 0x003A2A14
	private cu0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060093F8 RID: 37880 RVA: 0x003A4820 File Offset: 0x003A2A20
	public cu0(int A_0, double A_1) : base("battleTrance", "Боевой транс", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Status.BattleTrance";
		base.Power = (int)(A_1 * 100.0);
		base.Stacking = axm.b;
		foreach (csn csn in new axp().b)
		{
			if (csn is cxd || csn is eoh)
			{
				base.StaticEffects.Add(new bxb(csn.Name, (float)A_1));
			}
		}
	}

	// Token: 0x060093F9 RID: 37881 RVA: 0x003A48E0 File Offset: 0x003A2AE0
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/BattleTrance", new object[]
		{
			base.Power
		});
	}
}
