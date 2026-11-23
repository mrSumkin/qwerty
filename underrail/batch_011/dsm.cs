using System;
using Microsoft.Xna.Framework;

// Token: 0x0200208B RID: 8331
public sealed class dsm : daj
{
	// Token: 0x0600C729 RID: 50985 RVA: 0x0046081C File Offset: 0x0045EA1C
	public dsm()
	{
		this.a();
	}

	// Token: 0x0600C72A RID: 50986 RVA: 0x0046082C File Offset: 0x0045EA2C
	private void a()
	{
		esj esj = bpo.GetServiceOrThrow<bef>().k4();
		base.Size = esj;
		wj wj = wj.a();
		if (wj.c())
		{
			esj esj2 = new esj(1024, 500);
			Point point = new Point((esj.c - esj2.c) / 2, (esj.d - esj2.d) / 2);
			d7w d7w = new d7w();
			d7w.Text = "Загрузка...";
			d7w.Location = new Point(0, point.Y + esj2.d + 20);
			d7w.Size = new esj(esj.c - 20, 30);
			d7w.a(ad4.b);
			d7w.a(cab.c);
			d7w.a(egg.b);
			d7w.Color = adi.a;
			this.aox(d7w);
			return;
		}
		d7w d7w2 = new d7w();
		d7w2.a(true);
		d7w2.Text = "Загрузка...";
		d7w2.a(wj.ah);
		d7w2.Location = new Point(base.Size.c - d7w2.Size.c - wj.aj.Width, (int)((float)base.Size.d * 0.8f) - d7w2.Size.d / 2 + wj.ai.Y);
		d7w2.Color = adi.a;
		this.aox(d7w2);
		bg1 bg = new bg1();
		bg.b = wj.f;
		bg.d = new Rectangle?(wj.aj);
		bg.Size = new esj(wj.aj.Width, wj.aj.Height);
		bg.Location = new Point(d7w2.Location.X - (int)((float)bg.Size.c * 1.5f), (int)((float)base.Size.d * 0.8f) - bg.Size.d / 2);
		bg.Color = adi.a;
		this.aox(bg);
	}
}
