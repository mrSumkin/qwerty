using System;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common;

// Token: 0x0200186F RID: 6255
[e79(TimelapseWorkflows.CompensateExportCharacter)]
public sealed class v1 : b8q, eyp
{
	// Token: 0x06008516 RID: 34070 RVA: 0x003753F8 File Offset: 0x003735F8
	public v1(dsi A_0)
	{
		this.a = A_0;
		base.f().Add(new evs(new esj(450, 140), this, "Ошибка", "Не удалось экспортировать персонажа.", new Color?(Color.Red), null, "OK", "OK", new cpk[]
		{
			new cpk("OK", "OK", true)
		}));
		base.f().Add(new by());
	}

	// Token: 0x06008517 RID: 34071 RVA: 0x00375488 File Offset: 0x00373688
	public void g0(string A_0)
	{
		bpo.GetServiceOrThrow<d4m>().avp(new eme(this.a));
	}

	// Token: 0x040032FD RID: 13053
	private new dsi a;
}
