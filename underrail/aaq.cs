using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000985 RID: 2437
[eiz("UPHLJMP")]
[Serializable]
public sealed class aaq : bdw, ISerializable
{
	// Token: 0x06003B0F RID: 15119 RVA: 0x0015E75C File Offset: 0x0015C95C
	private aaq(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B10 RID: 15120 RVA: 0x0015E764 File Offset: 0x0015C964
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B11 RID: 15121 RVA: 0x0015E768 File Offset: 0x0015C968
	public aaq()
	{
	}

	// Token: 0x06003B12 RID: 15122 RVA: 0x0015E774 File Offset: 0x0015C974
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.h.b != null)
			{
				int a_ = (int)(c5x.h.b.aa().Defense.q().zm() / 2f);
				cwt cwt = new cwt();
				cwt.b = true;
				cwt.p = true;
				cwt.l = true;
				cwt.f.Add(new csk(DamageType.Mechanical, a_));
				cwt.y = "{2} падает, получая ";
				akg a_2 = new akg(null, c5x.h.b, cwt, null, false);
				c5x.Zone.ActionManager.g9(a_2, atp.a);
			}
		}
	}
}
