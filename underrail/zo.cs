using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;

// Token: 0x02002151 RID: 8529
[bmq("1.1.0.1_NewBurningBarrels", "1.1.0.1", "*", true)]
public sealed class zo : fg
{
	// Token: 0x0600C8E9 RID: 51433 RVA: 0x0046F2C0 File Offset: 0x0046D4C0
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			foreach (aud aud in A_1.Areas)
			{
				foreach (b0b b0b in aud.Entities)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.Layer == aju.x)
					{
						cd0 aspect = c5x.GetAspect<cd0>();
						if (aspect != null && aspect.a == "Objects\\Containers\\BurningBarrel")
						{
							int num = (aspect.b.Y > 1) ? 5 : 0;
							c5x.RemoveAspect<cd0>();
							alv alv = new alv(c5x);
							alv.a(new cd0(c5x)
							{
								a = "Objects\\Containers\\Barrel_Simple",
								b = new Point(0, 1)
							});
							etz etz = new etz(c5x);
							etz.a = "Effects\\BarrelFire";
							etz.b(1);
							etz.d(100);
							etz.c(32);
							etz.g = new float?((float)1);
							etz.a(true);
							alv.a(etz);
							etz etz2 = new etz(c5x);
							etz2.a = "Effects\\BarrelEmber";
							etz2.b(1);
							etz2.d(90);
							etz2.c(80);
							etz2.g = new float?((float)1);
							etz2.a(true);
							alv.a(etz2);
							etz etz3 = new etz(c5x);
							etz3.a = "Effects\\BarrelEmberLoop";
							etz3.b(1);
							etz3.d(100);
							etz3.c(30);
							etz3.g = new float?((float)1);
							etz3.a(true);
							alv.a(etz3);
							alv.a(new cd0(c5x)
							{
								a = "Objects\\Containers\\Barrel_Simple",
								b = new Point(0, 2)
							});
							c5x.SetAspect<alv>(alv);
							int num2 = num + new Random(c5x.GetHashCode()).Next(5);
							for (int i = 0; i < num2; i++)
							{
								c5x.aji();
							}
						}
					}
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}
