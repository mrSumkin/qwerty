using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Game.Data;

// Token: 0x0200076B RID: 1899
public sealed class d69 : a7m, amj
{
	// Token: 0x06003012 RID: 12306 RVA: 0x00123CC0 File Offset: 0x00121EC0
	public d69(dbn A_0) : base(A_0)
	{
		this.b();
	}

	// Token: 0x06003013 RID: 12307 RVA: 0x00123CD4 File Offset: 0x00121ED4
	private void b()
	{
		li service = bpo.GetService<li>();
		this.k = new eg0();
		if (service != null)
		{
			base.a(service.j9());
			this.c = service.j9().a;
		}
		this.d.a(0.125f);
		this.f = new dsy(this, this, esj.a(), cq4.a(400), null, null, 250, true, true);
		this.a();
	}

	// Token: 0x06003014 RID: 12308 RVA: 0x00123D60 File Offset: 0x00121F60
	private void a()
	{
		if (this.f != null)
		{
			Point point = base.at();
			this.f.a(cq4.a(400));
			this.f.a(Math.Min((int)((float)base.Size.c * 0.66f), this.f.d()));
			this.f.a(new Point?(new Point(point.X + base.Size.c - 10, point.Y + base.Size.d - 10)));
		}
	}

	// Token: 0x06003015 RID: 12309 RVA: 0x00123E04 File Offset: 0x00122004
	public override void ag5(e6d A_0)
	{
		this.a();
		this.f.b();
		this.d = null;
		this.b = A_0;
		bpo.GetService<ps>();
		cnk service = bpo.GetService<cnk>();
		if (service != null)
		{
			this.a = service.aq1();
			this.ao = false;
			if (this.a != null)
			{
				this.ao = this.a.g().e;
			}
			if (service.aqu() != null)
			{
				this.d = service.aqu().v();
				bfc bfc = service.ar0(service.aqu().c().b(), service.aqu());
				e5f serviceOrThrow = bpo.GetServiceOrThrow<e5f>();
				if (bfc != null)
				{
					string text = bfc.Id;
					if (service.aqu().r().GetPrimitivePropertyValue<bool>("dungeon_" + text, new bool?(false)).Value)
					{
						string classPropertyValue = service.aqu().r().GetClassPropertyValue<string>(string.Format("dungeon_{0}_sourceLocale", text));
						if (!string.IsNullOrEmpty(classPropertyValue))
						{
							text = classPropertyValue;
						}
					}
					if (serviceOrThrow.ase(text))
					{
						this.e = text;
					}
					else
					{
						this.e = "unknown";
					}
				}
				else
				{
					this.e = "unknown";
				}
			}
		}
		base.ag5(A_0);
	}

	// Token: 0x06003016 RID: 12310 RVA: 0x00123F58 File Offset: 0x00122158
	public override void iv(e6d A_0, cp9 A_1)
	{
		base.iv(A_0, A_1);
		this.f.a(A_0);
	}

	// Token: 0x06003017 RID: 12311 RVA: 0x00123F74 File Offset: 0x00122174
	public ecs yf(euz A_0)
	{
		ecs ecs = null;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (base.an2() != null)
		{
			e5f serviceOrThrow2 = bpo.GetServiceOrThrow<e5f>();
			dy9 aspect = base.an2().GetAspect<dy9>();
			if (aspect != null && (aspect.a() == MapNodeState.Revealed || aspect.h()))
			{
				string text = "";
				if (!string.IsNullOrEmpty(aspect.g()))
				{
					text = aspect.g();
				}
				else if (aspect.b().Count > 0)
				{
					bfc bfc = serviceOrThrow.ar0(Enumerable.FirstOrDefault<string>(aspect.b()), serviceOrThrow.aqu());
					if (bfc != null)
					{
						text = bfc.Name;
					}
				}
				if (!string.IsNullOrWhiteSpace(text))
				{
					string text2;
					if (!string.IsNullOrEmpty(aspect.d()))
					{
						text2 = qv.b("Maps/" + aspect.d());
					}
					else
					{
						text2 = qv.b("Maps/" + text.Replace(" ", ""));
					}
					if (string.IsNullOrWhiteSpace(text2))
					{
						text2 = "В этой области нет ничего особенного.";
					}
					string a_ = text;
					ecs = new ecs(new List<dl6>
					{
						new dl6(new List<bph>
						{
							new bph(new d22(cq4.c(), adi.c), a_, null)
						}),
						new dl6(new List<bph>
						{
							new bph(new d22(cq4.c(), Color.White), " ", null)
						}),
						new dl6(new List<bph>
						{
							new bph(new d22(cq4.c(), Color.Gray), text2, null)
						})
					});
					List<string> list = serviceOrThrow2.asi(base.an2());
					bool flag = false;
					foreach (string text3 in list)
					{
						if (text3 != null)
						{
							bs7 bs = dfz.a(text3);
							if (bs != null)
							{
								if (!flag)
								{
									ecs.a.AddRange(new dl6[]
									{
										new dl6(new List<bph>
										{
											new bph(new d22(cq4.c(), Color.White), " ", null)
										}),
										new dl6(new List<bph>
										{
											new bph(new d22(cq4.c(), Color.Green), "Имеется:", null)
										})
									});
									flag = true;
								}
								ecs.a.Add(new dl6(new List<bph>
								{
									new bph(new d22(cq4.c(), bs.b), " - " + bs.a, null)
								}));
							}
						}
					}
				}
			}
			if (aspect != null)
			{
				string[] array = serviceOrThrow.aqu().q().b(base.an2());
				if (array != null)
				{
					if (ecs == null)
					{
						ecs = new ecs();
						ecs.a.AddRange(new dl6[]
						{
							new dl6(new List<bph>
							{
								new bph(new d22(cq4.c(), Color.Gray), "Неисследованная область", null)
							}),
							new dl6(new List<bph>
							{
								new bph(new d22(cq4.c(), Color.White), " ", null)
							})
						});
					}
					else
					{
						ecs.a.Add(new dl6(new List<bph>
						{
							new bph(new d22(cq4.c(), Color.White), " ", null)
						}));
					}
					foreach (string text4 in array)
					{
						if (!string.IsNullOrWhiteSpace(text4))
						{
							ecs.a.Add(new dl6(new List<bph>
							{
								new bph(new d22(cq4.c(), adi.a), text4, null)
							}));
						}
					}
				}
			}
			djr aspect2 = base.an2().GetAspect<djr>();
			if (aspect2 != null && !string.IsNullOrEmpty(aspect2.b()) && serviceOrThrow2.asj(aspect2.a8()))
			{
				bool flag2 = false;
				if (aspect != null && aspect.a() == MapNodeState.Revealed)
				{
					flag2 = true;
				}
				if (!flag2)
				{
					ay0 aspect3 = base.an2().GetAspect<ay0>();
					if (aspect3 != null && aspect3.a() == MapNodeState.Revealed)
					{
						flag2 = true;
					}
				}
				GlobalMap globalMap;
				if (flag2 && serviceOrThrow2.asc().TryGetValue(aspect2.b(), out globalMap))
				{
					if (ecs != null)
					{
						ecs.a.Add(new dl6(new List<bph>
						{
							new bph(new d22(cq4.c(), Color.White), " ", null)
						}));
					}
					else
					{
						ecs = new ecs();
					}
					ecs.a.Add(new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.Yellow), "Нажмите, чтобы перейти к ", null),
						new bph(new d22(cq4.c(), Color.White), string.Format("{0}", globalMap.ToString().a()), null),
						new bph(new d22(cq4.c(), Color.Yellow), " карте.", null)
					}));
				}
			}
			if (aspect != null && aspect.a() != MapNodeState.Obscured)
			{
				if (ecs == null)
				{
					ecs = new ecs();
				}
				else
				{
					ecs.a.Add(new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.White), " ", null)
					}));
				}
				ecs.a.Add(new dl6(new List<bph>
				{
					new bph(new d22(cq4.c(), Color.Yellow), "Shift + ЛКМ заметки игрока.", null)
				}));
			}
		}
		return ecs;
	}

	// Token: 0x06003018 RID: 12312 RVA: 0x0012457C File Offset: 0x0012277C
	protected override void it(object A_0, b25 A_1)
	{
		base.it(A_0, A_1);
		if (this.e != null && this.e.a)
		{
			KeyboardState state = Keyboard.GetState();
			if (state.IsKeyDown(Keys.LeftShift) || state.IsKeyDown(Keys.RightShift))
			{
				base.an9().uo((float)(A_1.c() / 120) * this.e.b);
				base.f();
			}
		}
	}

	// Token: 0x04001A48 RID: 6728
	public new ls a;

	// Token: 0x04001A49 RID: 6729
	public new e6d b;

	// Token: 0x04001A4A RID: 6730
	public new esj c;

	// Token: 0x04001A4B RID: 6731
	public new au2 d;

	// Token: 0x04001A4C RID: 6732
	public new string e;

	// Token: 0x04001A4D RID: 6733
	private new dsy f;
}
