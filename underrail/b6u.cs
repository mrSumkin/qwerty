using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Ouroboros.Common.Data;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001FFA RID: 8186
public sealed class b6u : euz
{
	// Token: 0x0600C108 RID: 49416 RVA: 0x0042DCC0 File Offset: 0x0042BEC0
	static b6u()
	{
		b6u.a();
	}

	// Token: 0x0600C109 RID: 49417 RVA: 0x0042DCC8 File Offset: 0x0042BEC8
	public b6u(TypedObjectReference<efk> A_0)
	{
		this.i = A_0;
		wj wj = wj.a();
		if (!wj.c())
		{
			this.j = wj.iw;
			this.k = wj.ix;
		}
	}

	// Token: 0x0600C10A RID: 49418 RVA: 0x0042DD18 File Offset: 0x0042BF18
	public override void iv(e6d A_0, cp9 A_1)
	{
		base.iv(A_0, A_1);
		if (this.i != null && this.i.ao() != null)
		{
			cd1 cd = this.i.ao().Offense.u();
			string text;
			b6u.b.TryGetValue(cd.TypedDefinition.ak(), out text);
			Texture2D resource;
			if (!string.IsNullOrEmpty(text))
			{
				resource = A_1.a.GetResource<Texture2D>(Path.Combine(d5x.a, text), null);
			}
			else
			{
				resource = A_1.a.GetResource<Texture2D>(bo1.br, null);
			}
			if (resource != null)
			{
				if (cd.TypedDefinition.ak() == AmmoType.Bolts)
				{
					Point point = base.at();
					Rectangle a_ = new Rectangle(point.X + base.Size.c - (int)((float)b6u.f.Width * this.j), point.Y + base.Size.d - (int)((float)b6u.f.Height * this.j), (int)((float)b6u.f.Width * this.j), (int)((float)b6u.f.Height * this.j));
					int num = eub.c(this.i.ao());
					int num2 = Math.Min(25, num);
					if (num <= 0)
					{
						a_.Width = (int)((float)b6u.g.Width * this.j);
						a_.Height = (int)((float)b6u.g.Height * this.j);
						A_1.b().w6(resource, a_, new Rectangle?(b6u.g), Color.White);
						return;
					}
					for (int i = 0; i < num2; i++)
					{
						A_1.b().w6(resource, a_, new Rectangle?(b6u.f), Color.White);
						a_.X -= (int)((float)b6u.f.Width * this.j / 2f);
					}
					if (num > num2)
					{
						a_.Width = (int)((float)b6u.h.Width * this.j);
						a_.Height = (int)((float)b6u.h.Height * this.j);
						A_1.b().w6(resource, a_, new Rectangle?(b6u.h), Color.White);
						return;
					}
				}
				else if (cd.MaxBattery > 0)
				{
					double num3 = Math.Min(1.0, (double)cd.MaxBattery / 250.0);
					if (num3 > 0.0)
					{
						Point point2 = base.at();
						wj wj = wj.a();
						if (wj.c())
						{
							int num4 = (int)((double)b6u.e.Width * num3);
							Rectangle a_2 = new Rectangle(point2.X + base.Size.c - (int)((float)num4 * this.j), point2.Y + base.Size.d - (int)((float)b6u.e.Height * this.j) - 3, (int)((float)num4 * this.j), (int)((float)b6u.e.Height * this.j));
							Rectangle value = new Rectangle(b6u.e.X + (b6u.e.Width - num4), b6u.e.Y, num4, b6u.e.Height);
							A_1.b().w6(resource, a_2, new Rectangle?(value), adi.b * 0.5f);
							double num5 = cd.Battery / (double)cd.MaxBattery;
							if (num5 > 0.0)
							{
								int num6 = (int)Math.Ceiling(num5 * (double)num4);
								value.X = b6u.e.X + (b6u.e.Width - num6);
								value.Width = num6;
								a_2.X = point2.X + base.Size.c - (int)((float)num6 * this.j);
								a_2.Width = (int)((float)num6 * this.j);
								Color darkRed;
								if (cd.Battery >= cd.TypedDefinition.k())
								{
									darkRed = adi.c;
								}
								else
								{
									darkRed = Color.DarkRed;
								}
								A_1.b().w6(resource, a_2, new Rectangle?(value), darkRed);
								return;
							}
						}
						else
						{
							Texture2D texture2D = A_1.a.us(bo1.br + "_" + wj.e, null);
							if (texture2D != null)
							{
								int num7 = (int)(num3 * (double)Math.Min(this.k, texture2D.Width));
								num7 -= 6;
								num7 += 9 - num7 % 9;
								num7 += 6;
								Rectangle value2 = new Rectangle(texture2D.Width - num7, b6u.e.Y, num7, texture2D.Height);
								Vector2 a_3 = new Vector2((float)(point2.X + base.Size.c - num7), (float)(point2.Y + base.Size.d - texture2D.Height - 3));
								A_1.b().w5(texture2D, a_3, new Rectangle?(value2), adi.b * 0.5f);
								double num8 = cd.Battery / (double)cd.MaxBattery;
								if (num8 > 0.0)
								{
									int num9 = (int)Math.Ceiling(num8 * (double)num7);
									value2.X = texture2D.Width - num9;
									value2.Width = num9;
									a_3 = new Vector2((float)(point2.X + base.Size.c - num9), (float)(point2.Y + base.Size.d - texture2D.Height - 3));
									Color darkRed2;
									if (cd.Battery >= cd.TypedDefinition.k())
									{
										darkRed2 = adi.c;
									}
									else
									{
										darkRed2 = Color.DarkRed;
									}
									A_1.b().w5(texture2D, a_3, new Rectangle?(value2), darkRed2);
									return;
								}
							}
						}
					}
				}
				else
				{
					float num10 = this.j;
					if (cd.TypedDefinition.f() > 30)
					{
						num10 *= 0.5f;
					}
					Rectangle rectangle;
					if (b6u.c.TryGetValue(cd.TypedDefinition.ak(), out rectangle))
					{
						Point point3 = base.at();
						Rectangle rectangle2 = new Rectangle(point3.X + base.Size.c - (int)((float)rectangle.Width * num10), point3.Y + base.Size.d - (int)((float)rectangle.Height * num10), (int)((float)rectangle.Width * num10), (int)((float)rectangle.Height * num10));
						int num11;
						b6u.d.TryGetValue(cd.TypedDefinition.ak(), out num11);
						for (int j = cd.LoadedAmmo.Count - 1; j >= cd.LoadedAmmo.Count - cd.TypedDefinition.f(); j--)
						{
							Rectangle value3;
							Color a_4;
							if (j >= 0)
							{
								AmmoType ammoType = cd.LoadedAmmo[j];
								int num12 = Math.Max(1, ammoType - cd.TypedDefinition.ak());
								value3 = rectangle;
								value3.X += num12 * rectangle.Width;
								a_4 = Color.White;
							}
							else
							{
								value3 = rectangle;
								a_4 = Color.White * 0.5f;
							}
							A_1.b().w6(resource, rectangle2, new Rectangle?(value3), a_4);
							rectangle2.X -= (int)((float)(rectangle.Width + num11) * num10);
							if (rectangle2.X < point3.X)
							{
								rectangle2.Y -= (int)((float)(rectangle.Height + num11) * num10);
								rectangle2.X = point3.X + base.Size.c - (int)((float)rectangle.Width * num10);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C10B RID: 49419 RVA: 0x0042E518 File Offset: 0x0042C718
	public override bool iz(MouseState A_0)
	{
		return false;
	}

	// Token: 0x0600C10C RID: 49420 RVA: 0x0042E520 File Offset: 0x0042C720
	private new static void a()
	{
		b6u.e = new Rectangle(0, 0, 598, 25);
		b6u.f = new Rectangle(598, 0, 21, 35);
		b6u.g = new Rectangle(619, 0, 21, 35);
		b6u.h = new Rectangle(640, 0, 21, 35);
		b6u.c = new Dictionary<AmmoType, Rectangle>();
		b6u.c[AmmoType.Caliber_5] = new Rectangle(0, 25, 13, 35);
		b6u.c[AmmoType.Caliber_762] = new Rectangle(78, 25, 14, 44);
		b6u.c[AmmoType.Caliber_86] = new Rectangle(158, 25, 15, 45);
		b6u.c[AmmoType.Caliber_9] = new Rectangle(243, 25, 16, 49);
		b6u.c[AmmoType.Caliber_44] = new Rectangle(338, 25, 17, 43);
		b6u.c[AmmoType.Caliber_127] = new Rectangle(438, 25, 18, 52);
		b6u.c[AmmoType.Vial_Acid] = new Rectangle(0, 74, 34, 35);
		b6u.c[AmmoType.Vial_Cryogel] = new Rectangle(0, 109, 34, 35);
		b6u.c[AmmoType.Vial_Incendiary] = new Rectangle(0, 144, 34, 35);
		b6u.c[AmmoType.ShotgunShell] = new Rectangle(0, 0, 21, 44);
		b6u.c[AmmoType.Grenade_25] = new Rectangle(0, 0, 19, 53);
		b6u.c[AmmoType.Grenade_40] = new Rectangle(0, 53, 24, 47);
		b6u.c[AmmoType.Rocket_40] = new Rectangle(0, 164, 20, 64);
		b6u.c[AmmoType.Rocket_66] = new Rectangle(0, 228, 20, 64);
		b6u.c[AmmoType.Rocket_84] = new Rectangle(0, 100, 20, 64);
		b6u.b = new Dictionary<AmmoType, string>();
		b6u.b[AmmoType.ShotgunShell] = "xpbl_Ammo";
		b6u.b[AmmoType.Grenade_25] = "xphw_Ammo";
		b6u.b[AmmoType.Grenade_40] = "xphw_Ammo";
		b6u.b[AmmoType.Rocket_40] = "xphw_Ammo";
		b6u.b[AmmoType.Rocket_66] = "xphw_Ammo";
		b6u.b[AmmoType.Rocket_84] = "xphw_Ammo";
		b6u.d = new Dictionary<AmmoType, int>();
		b6u.d[AmmoType.Vial_Acid] = -10;
		b6u.d[AmmoType.Vial_Cryogel] = -10;
		b6u.d[AmmoType.Vial_Incendiary] = -10;
	}

	// Token: 0x040045CC RID: 17868
	private new const int a = 250;

	// Token: 0x040045CD RID: 17869
	private new static Dictionary<AmmoType, string> b;

	// Token: 0x040045CE RID: 17870
	private new static Dictionary<AmmoType, Rectangle> c;

	// Token: 0x040045CF RID: 17871
	private new static Dictionary<AmmoType, int> d;

	// Token: 0x040045D0 RID: 17872
	private new static Rectangle e;

	// Token: 0x040045D1 RID: 17873
	private new static Rectangle f;

	// Token: 0x040045D2 RID: 17874
	private new static Rectangle g;

	// Token: 0x040045D3 RID: 17875
	private static Rectangle h;

	// Token: 0x040045D4 RID: 17876
	private TypedObjectReference<efk> i;

	// Token: 0x040045D5 RID: 17877
	private new float j = 1f;

	// Token: 0x040045D6 RID: 17878
	private new int k;
}
