using System;
using System.Runtime.Serialization;

// Token: 0x020016E8 RID: 5864
[eiz("LOA")]
[Serializable]
public sealed class cbl : a6k, ISerializable
{
	// Token: 0x06007F7D RID: 32637 RVA: 0x0035FE18 File Offset: 0x0035E018
	private cbl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F7E RID: 32638 RVA: 0x0035FE24 File Offset: 0x0035E024
	public cbl()
	{
	}

	// Token: 0x06007F7F RID: 32639 RVA: 0x0035FE30 File Offset: 0x0035E030
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() == null || base.vg().q().h == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null)
		{
			return dc4.e;
		}
		d2b aspect = c5x.GetAspect<d2b>();
		if (aspect == null)
		{
			return dc4.e;
		}
		bool flag = (base.vg().q().g & e2b.d) > (e2b)0;
		switch (aspect.c(base.vg().q().h.b))
		{
		case c9b.a:
			if (flag)
			{
				a7v.a(new e5s());
				bmj.a(c5x, new d53("Заперто", adi.h, null, false));
			}
			return dc4.c;
		case c9b.b:
			if (flag)
			{
				a7v.a(new cpt("Запереть не удалось. У вас нет подходящего ключа."));
			}
			return dc4.e;
		case c9b.c:
			if (flag)
			{
				a7v.a(new cpt("Запереть не удалось. Этот объект нельзя запереть."));
			}
			return dc4.e;
		case c9b.d:
			if (flag)
			{
				a7v.a(new cpt("Запереть не удалось. Этот объект уже заперт."));
			}
			return dc4.e;
		case c9b.f:
			if (flag)
			{
				a7v.a(new cpt("Запереть не удалось. Этот объект нельзя запереть в таком положении."));
			}
			return dc4.e;
		case c9b.g:
			bmj.a(c5x, new d53("Нет питания", adi.l, null, true));
			return dc4.e;
		}
		return dc4.e;
	}
}
