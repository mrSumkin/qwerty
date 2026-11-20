using System;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common;

// Token: 0x0200186E RID: 6254
[e79(TimelapseWorkflows.CompensateChangeZone)]
public sealed class hr : b8q, eyp
{
	// Token: 0x06008514 RID: 34068 RVA: 0x0037531C File Offset: 0x0037351C
	public hr(di4 A_0)
	{
		this.a = A_0;
		base.f().Add(new ba4());
		base.f().Add(new av2());
		base.f().Add(new b8y());
		base.f().Add(new evs(new esj(450, 140), this, "Ошибка", "Не удалось перейти в область.", new Color?(Color.Red), null, "OK", "OK", new cpk[]
		{
			new cpk("OK", "OK", true)
		}));
		base.f().Add(new by());
	}

	// Token: 0x06008515 RID: 34069 RVA: 0x003753DC File Offset: 0x003735DC
	public void g0(string A_0)
	{
		bpo.GetServiceOrThrow<d4m>().avp(new a19(this.a));
	}

	// Token: 0x040032FC RID: 13052
	private new di4 a;
}
