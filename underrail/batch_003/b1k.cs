using System;
using System.IO;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common;

// Token: 0x0200186C RID: 6252
[e79(TimelapseWorkflows.CompensateLoadGame)]
public sealed class b1k : b8q, eyp
{
	// Token: 0x06008510 RID: 34064 RVA: 0x003751B0 File Offset: 0x003733B0
	public b1k(Exception A_0)
	{
		string str;
		if (A_0 is InvalidDataException)
		{
			str = "Повреждение данных.";
		}
		else
		{
			str = A_0.Message;
		}
		base.f().Add(new evs(new esj(500, 240), this, "Ошибка", "Не удалось загрузить сохранение. Ошибка: " + str, new Color?(Color.Red), null, "OK", "OK", new cpk[]
		{
			new cpk("OK", "OK", true)
		}));
		base.f().Add(new by());
	}

	// Token: 0x06008511 RID: 34065 RVA: 0x0037525C File Offset: 0x0037345C
	public void g0(string A_0)
	{
		bpo.GetServiceOrThrow<d4m>().avp(new a19());
	}
}
