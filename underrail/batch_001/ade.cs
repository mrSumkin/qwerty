using System;
using System.Runtime.Serialization;

// Token: 0x02001A0A RID: 6666
[eiz("CPFX")]
[Serializable]
public sealed class ade : d3e, ISerializable
{
	// Token: 0x06008FEF RID: 36847 RVA: 0x00399138 File Offset: 0x00397338
	private ade(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008FF0 RID: 36848 RVA: 0x00399144 File Offset: 0x00397344
	public ade()
	{
	}

	// Token: 0x06008FF1 RID: 36849 RVA: 0x00399150 File Offset: 0x00397350
	protected override void @in(ll A_0)
	{
		if (A_0.a().Offense.am() > cd7.c)
		{
			double num = (double)((int)Math.Round((A_0.a().Offense.am() - cd7.c) / cd7.b, 5)) * (cd7.a + (double)A_0.a().GetSpecializationValue<er>(true) * er.a);
			dcu dcu = A_0.a().Offense;
			dcu.g(dcu.am() + num);
		}
	}

	// Token: 0x06008FF2 RID: 36850 RVA: 0x003991D0 File Offset: 0x003973D0
	public override d3e b3()
	{
		ade ade = new ade();
		this.xx(ade);
		return ade;
	}
}
