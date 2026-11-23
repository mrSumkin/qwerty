using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001389 RID: 5001
[bs6("HFX:rapidReload")]
[eiz("RRHEA")]
[Serializable]
public sealed class c0y : cpl, ISerializable
{
	// Token: 0x06007127 RID: 28967 RVA: 0x002F8034 File Offset: 0x002F6234
	private c0y(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007128 RID: 28968 RVA: 0x002F8040 File Offset: 0x002F6240
	public c0y()
	{
	}

	// Token: 0x06007129 RID: 28969 RVA: 0x002F8048 File Offset: 0x002F6248
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.a() == null && base.a().aa() != null && base.a().a8() != null)
		{
			return dc4.e;
		}
		d02 service = bpo.GetService<d02>();
		if (service == null || !service.ahg())
		{
			return dc4.c;
		}
		d4n d4n = service.ahu(base.a().aa());
		if (d4n != service.ahe())
		{
			return dc4.c;
		}
		ip ip = base.a().aa().Cooldowns.b("rapidReloadHitEffect");
		if (ip == null || ip.a <= 0.0)
		{
			int num = cuo.a.Next(base.agu().Power / 2, base.agu().Power + 1);
			d4n.c += (double)num;
			bmj.a(base.a().a8(), new d53(string.Format("+{0} очков действия", num), adi.ap, null, false));
			vr a_ = new vr(new ap9(base.a().aa()), null, "{0} получает " + num.ToString() + " очков действия.", new Color?(adi.ap), null);
			bey.a(a_, base.a().aa(), base.a());
			a7v.a(a_);
			base.a().aa().Cooldowns.a(new cfd[]
			{
				new cfd("rapidReloadHitEffect", d0u.b, false, true)
			});
		}
		return dc4.c;
	}
}
