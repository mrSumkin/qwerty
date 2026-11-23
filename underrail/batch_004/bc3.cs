using System;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common;

// Token: 0x0200186D RID: 6253
[e79(TimelapseWorkflows.CompensateSaveGame)]
public sealed class bc3 : b8q, eyp
{
	// Token: 0x06008512 RID: 34066 RVA: 0x00375270 File Offset: 0x00373470
	public bc3(al1 A_0)
	{
		this.a = A_0;
		base.f().Add(new evs(new esj(450, 140), this, "Ошибка", "Не удалось сохранить игру.", new Color?(Color.Red), null, "OK", "OK", new cpk[]
		{
			new cpk("OK", "OK", true)
		}));
		base.f().Add(new by());
	}

	// Token: 0x06008513 RID: 34067 RVA: 0x00375300 File Offset: 0x00373500
	public void g0(string A_0)
	{
		bpo.GetServiceOrThrow<d4m>().avp(new clx(this.a));
	}

	// Token: 0x040032FB RID: 13051
	private new al1 a;
}
