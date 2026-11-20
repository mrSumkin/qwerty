using System;
using System.Runtime.Serialization;

// Token: 0x02001A05 RID: 6661
[eiz("C43")]
[Serializable]
public sealed class yt : d91, ISerializable
{
	// Token: 0x06008FD4 RID: 36820 RVA: 0x00398D14 File Offset: 0x00396F14
	private yt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008FD5 RID: 36821 RVA: 0x00398D20 File Offset: 0x00396F20
	public yt()
	{
	}

	// Token: 0x06008FD6 RID: 36822 RVA: 0x00398D28 File Offset: 0x00396F28
	public yt(double A_0) : base(A_0)
	{
	}

	// Token: 0x06008FD7 RID: 36823 RVA: 0x00398D34 File Offset: 0x00396F34
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		dcu dcu = A_0.a().Offense;
		dcu.j(dcu.aw() + base.b());
	}

	// Token: 0x06008FD8 RID: 36824 RVA: 0x00398D6C File Offset: 0x00396F6C
	public override string b2()
	{
		if (base.b() >= 0.0)
		{
			return string.Format("Шанс попадания метательным оружием увеличен на {0}%", base.b() * 100.0);
		}
		return string.Format("Шанс попадания метательным оружием уменьшен на {0}%", Math.Abs(base.b()) * 100.0);
	}

	// Token: 0x06008FD9 RID: 36825 RVA: 0x00398DD4 File Offset: 0x00396FD4
	public override d3e b3()
	{
		yt yt = new yt();
		this.xx(yt);
		return yt;
	}
}
