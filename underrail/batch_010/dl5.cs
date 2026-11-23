using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Common;
using TimelapseVertigo.Common.Data;
using TimelapseVertigo.Common.Settings;

// Token: 0x02002064 RID: 8292
public sealed class dl5 : euz, amj
{
	// Token: 0x0600C535 RID: 50485 RVA: 0x0044CBB0 File Offset: 0x0044ADB0
	public efk j()
	{
		return this.n;
	}

	// Token: 0x0600C536 RID: 50486 RVA: 0x0044CBB8 File Offset: 0x0044ADB8
	public void a(efk A_0)
	{
		if (this.n != A_0)
		{
			this.b();
			this.n = A_0;
			this.c();
		}
	}

	// Token: 0x0600C537 RID: 50487 RVA: 0x0044CBDC File Offset: 0x0044ADDC
	public c5x o()
	{
		return this.aj;
	}

	// Token: 0x0600C538 RID: 50488 RVA: 0x0044CBE4 File Offset: 0x0044ADE4
	public void a(c5x A_0)
	{
		this.aj = A_0;
	}

	// Token: 0x0600C539 RID: 50489 RVA: 0x0044CBF0 File Offset: 0x0044ADF0
	public bool m()
	{
		return this.y;
	}

	// Token: 0x0600C53A RID: 50490 RVA: 0x0044CBF8 File Offset: 0x0044ADF8
	public void c(bool A_0)
	{
		this.y = A_0;
	}

	// Token: 0x0600C53B RID: 50491 RVA: 0x0044CC04 File Offset: 0x0044AE04
	public bool l()
	{
		return this.x;
	}

	// Token: 0x0600C53C RID: 50492 RVA: 0x0044CC0C File Offset: 0x0044AE0C
	public void b(bool A_0)
	{
		this.x = A_0;
	}

	// Token: 0x0600C53D RID: 50493 RVA: 0x0044CC18 File Offset: 0x0044AE18
	public bool n()
	{
		return this.z;
	}

	// Token: 0x0600C53E RID: 50494 RVA: 0x0044CC20 File Offset: 0x0044AE20
	public void d(bool A_0)
	{
		this.z = A_0;
	}

	// Token: 0x0600C53F RID: 50495 RVA: 0x0044CC2C File Offset: 0x0044AE2C
	public bool k()
	{
		return this.w;
	}

	// Token: 0x0600C540 RID: 50496 RVA: 0x0044CC34 File Offset: 0x0044AE34
	public void a(bool A_0)
	{
		this.w = A_0;
	}

	// Token: 0x0600C541 RID: 50497 RVA: 0x0044CC40 File Offset: 0x0044AE40
	public bool i()
	{
		return this.ai;
	}

	// Token: 0x0600C542 RID: 50498 RVA: 0x0044CC48 File Offset: 0x0044AE48
	public void e(bool A_0)
	{
		this.ai = A_0;
	}

	// Token: 0x0600C543 RID: 50499 RVA: 0x0044CC54 File Offset: 0x0044AE54
	[CompilerGenerated]
	public void c(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.al;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.al, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C544 RID: 50500 RVA: 0x0044CC8C File Offset: 0x0044AE8C
	[CompilerGenerated]
	public void b(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.al;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.al, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C545 RID: 50501 RVA: 0x0044CCC4 File Offset: 0x0044AEC4
	[CompilerGenerated]
	public void a(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.am;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.am, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C546 RID: 50502 RVA: 0x0044CCFC File Offset: 0x0044AEFC
	[CompilerGenerated]
	public void d(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.am;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.am, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C547 RID: 50503 RVA: 0x0044CD34 File Offset: 0x0044AF34
	public dl5(float A_0 = 1f, bool A_1 = false, c5x A_2 = null)
	{
		this.f = A_0;
		this.ai = A_1;
		this.aj = A_2;
		this.h();
	}

	// Token: 0x0600C548 RID: 50504 RVA: 0x0044CD9C File Offset: 0x0044AF9C
	public dl5(efk A_0, float A_1 = 1f, bool A_2 = false, c5x A_3 = null)
	{
		this.f = A_1;
		this.n = A_0;
		this.ai = A_2;
		this.aj = A_3;
		this.g = (this.n is e3q);
		this.h();
	}

	// Token: 0x0600C549 RID: 50505 RVA: 0x0044CE20 File Offset: 0x0044B020
	public override void iv(e6d A_0, cp9 A_1)
	{
		if (this.n == null)
		{
			return;
		}
		this.a();
		base.iv(A_0, A_1);
		cne service = bpo.GetService<cne>();
		if (service != null)
		{
			wj wj = wj.a();
			if (wj.d == UiSize.Classic)
			{
				Texture2D resource = service.GetResource<Texture2D>(bo1.bo, null);
				if (resource != null)
				{
					int num = 0;
					if (this.y && this.n.IsInCombat)
					{
						ob ob = A_1.b();
						Texture2D a_ = resource;
						Vector2 a_2 = new Vector2((float)(this.h.Location.X + 15), (float)(this.h.Location.Y + this.h.Size.d - (this.b.d - 5)));
						esj esj = this.b;
						ob.w5(a_, a_2, new Rectangle?(new Rectangle(0, 0, this.b.c, this.b.d)), Color.White);
						num++;
					}
					if (this.x && this.n.Offense.af())
					{
						A_1.b().w5(resource, new Vector2((float)(this.h.Location.X + 15 + num * (this.b.c + 2)), (float)(this.h.Location.Y + this.h.Size.d - (this.b.d - 5))), new Rectangle?(new Rectangle(this.b.c, 0, this.b.c, this.b.d)), Color.White);
					}
				}
			}
			else
			{
				Texture2D resource2 = service.GetResource<Texture2D>(wj.f, null);
				if (resource2 != null)
				{
					int num2 = 0;
					if (this.y && this.n.IsInCombat)
					{
						A_1.b().w5(resource2, new Vector2((float)(this.h.Location.X + wj.bi), (float)(this.h.Location.Y + this.h.Size.d - wj.bh.d)), new Rectangle?(new Rectangle(wj.bg.X, wj.bg.Y, wj.bh.c, wj.bh.d)), Color.White);
						num2++;
					}
					if (this.x && this.n.Offense.af())
					{
						A_1.b().w5(resource2, new Vector2((float)(this.h.Location.X + wj.bi + num2 * (wj.bh.c + wj.bi / 2)), (float)(this.h.Location.Y + this.h.Size.d - wj.bh.d)), new Rectangle?(new Rectangle(wj.bg.X + wj.bh.c, wj.bg.Y, wj.bh.c, wj.bh.d)), Color.White);
						num2++;
					}
				}
			}
			if (this.m.Visible && wj.d == UiSize.Classic)
			{
				Texture2D texture2D = service.us(bo1.a0, null);
				if (texture2D != null)
				{
					int num3 = (int)(A_0.a().TotalGameTime.TotalMilliseconds / 150.0) % 10;
					Rectangle value = new Rectangle(110 * num3, 0, 110, 110);
					Vector2 a_3 = this.h.at().b();
					A_1.b().w5(texture2D, a_3, new Rectangle?(value), Color.White);
					int num4 = (int)(A_0.a().TotalGameTime.TotalMilliseconds / 150.0) % 16;
					if (num4 < 8)
					{
						Rectangle value2 = new Rectangle(num4 * 20, 120, 20, 20);
						Vector2 a_4 = this.m.at().b() + new Vector2(2f, 2f);
						A_1.b().w5(texture2D, a_4, new Rectangle?(value2), Color.White);
					}
				}
			}
		}
		this.o.a(A_0);
		this.p.a(A_0);
		this.q.a(A_0);
		this.r.a(A_0);
		this.s.a(A_0);
		this.t.a(A_0);
		this.u.a(A_0);
		this.v.a(A_0);
	}

	// Token: 0x0600C54A RID: 50506 RVA: 0x0044D310 File Offset: 0x0044B510
	public override void ag5(e6d A_0)
	{
		wj wj = wj.a();
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.n != null)
		{
			this.h.a(this.n.bd);
		}
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().c() != null)
		{
			bfc bfc = serviceOrThrow.ar0(serviceOrThrow.aqu().c().b(), serviceOrThrow.aqu());
			if (bfc != null)
			{
				this.h.b(bfc.LocaleType ?? "Default");
			}
		}
		if (serviceOrThrow.aq1().b().a())
		{
			if (this.aj != null && this.aj.j == cgy.b && this.h != null)
			{
				if (this.aj.ad != null)
				{
					this.h.b(this.aj.ad.Value);
				}
				else
				{
					Vector4 vector = this.aj.Lightning.ToVector4();
					Vector4 vector2 = Vector4.One;
					float num = 0f;
					amc amc = this.aj.h.b;
					if (amc != null)
					{
						if (amc.ao != null)
						{
							vector2 = amc.ao.Value.ToVector4();
						}
						if (amc.an != null)
						{
							num = amc.an.Value;
						}
					}
					vector2 = new Vector4(vector2.X * Math.Min(1f, num + vector.X * (1f - num)), vector2.Y * Math.Min(1f, num + vector.Y * (1f - num)), vector2.Z * Math.Min(1f, num + vector.Z * (1f - num)), vector2.W * Math.Min(1f, num + vector.W * (1f - num)));
					this.h.b(new Color(vector2));
				}
				this.h.a(this.aj.Lightning);
			}
		}
		else
		{
			this.h.b(Color.White);
			this.h.a(Color.White);
		}
		this.f();
		base.ag5(A_0);
		if (this.z && this.n != null)
		{
			if (wj.d == UiSize.Classic)
			{
				if (this.n.EncumbranceLevel != db9.a)
				{
					this.ae.Visible = true;
					this.ae.a(string.Format("Status.{0}", (int)(81 + this.n.EncumbranceLevel)));
					this.ae.b(this.ae.d());
					this.ae.c(this.ae.d());
				}
				else
				{
					this.ae.Visible = false;
				}
			}
			else if (this.n.EncumbranceLevel != db9.a)
			{
				this.ah.Visible = true;
				this.ah.d = new Rectangle?(new Rectangle((int)(wj.bj.X + (db9.b + (int)this.n.EncumbranceLevel) * (db9)wj.bk.c), wj.bj.Y, wj.bk.c, wj.bk.d));
			}
			else
			{
				this.ah.Visible = false;
			}
			this.aa = dl5.BrokenItemNotificationState.None;
			foreach (cgk cgk in new cgk[]
			{
				this.n.Gear.l().Item,
				this.n.Gear.g().Item,
				this.n.Gear.f().Item
			})
			{
				if (cgk != null && cgk.Definition != null && !cgk.Definition.a9() && cgk.MaxDurability > 0)
				{
					dl5.BrokenItemNotificationState brokenItemNotificationState = this.a(cgk);
					if (brokenItemNotificationState > this.aa)
					{
						this.aa = brokenItemNotificationState;
						if (this.aa == dl5.BrokenItemNotificationState.Broken)
						{
							break;
						}
					}
				}
			}
			if (this.n.Offense.u() != null && this.n.Offense.u().Definition != null && !this.n.Offense.u().Definition.a9() && this.n.Offense.u().MaxDurability > 0)
			{
				this.ab = this.a(this.n.Offense.u());
			}
			else
			{
				this.ab = dl5.BrokenItemNotificationState.None;
			}
			if (this.aa != dl5.BrokenItemNotificationState.None)
			{
				if (this.ac != null)
				{
					this.ac.Visible = true;
					this.ac.a("ArmorState." + this.aa.ToString());
					this.ac.b(this.ac.d());
					this.ac.c(this.ac.d());
				}
				else if (this.af != null)
				{
					this.af.Visible = true;
					this.af.d = new Rectangle?(new Rectangle(wj.bj.X + (this.aa - dl5.BrokenItemNotificationState.Damaged) * wj.bk.c, wj.bj.Y, wj.bk.c, wj.bk.d));
				}
			}
			else if (this.ac != null)
			{
				this.ac.Visible = false;
			}
			else if (this.af != null)
			{
				this.af.Visible = false;
			}
			if (this.ab != dl5.BrokenItemNotificationState.None)
			{
				if (this.ad != null)
				{
					this.ad.Visible = true;
					this.ad.a("WeaponState." + this.ab.ToString());
					this.ad.b(this.ad.d());
					this.ad.c(this.ad.d());
				}
				else if (this.ag != null)
				{
					this.ag.Visible = true;
					this.ag.d = new Rectangle?(new Rectangle(wj.bj.X + (this.ab - dl5.BrokenItemNotificationState.Damaged) * wj.bk.c, wj.bj.Y + wj.bk.d, wj.bk.c, wj.bk.d));
				}
			}
			else if (this.ad != null)
			{
				this.ad.Visible = false;
			}
			else if (this.ag != null)
			{
				this.ag.Visible = false;
			}
		}
		else if (wj.d == UiSize.Classic)
		{
			this.ac.Visible = false;
			this.ad.Visible = false;
			this.ae.Visible = false;
		}
		else
		{
			this.af.Visible = false;
			this.ag.Visible = false;
			this.ah.Visible = false;
		}
		this.ak.d = this.aj;
		this.ak.Visible = (this.n != null && this.n.Vehicle != null);
	}

	// Token: 0x0600C54B RID: 50507 RVA: 0x0044DB04 File Offset: 0x0044BD04
	public override bool iz(MouseState A_0)
	{
		return this.h.iz(A_0) || this.i.iz(A_0) || this.k.iz(A_0) || this.j.iz(A_0) || (this.ac != null && this.ac.iz(A_0)) || (this.ad != null && this.ad.iz(A_0)) || (this.ae != null && this.ae.iz(A_0)) || (this.af != null && this.af.iz(A_0)) || (this.ag != null && this.ag.iz(A_0)) || (this.ah != null && this.ah.iz(A_0)) || (this.ak.Visible && this.ak.iz(A_0));
	}

	// Token: 0x0600C54C RID: 50508 RVA: 0x0044DC38 File Offset: 0x0044BE38
	public ecs yf(euz A_0)
	{
		wj wj = wj.a();
		if (wj == null)
		{
			return null;
		}
		string a_;
		string a_2;
		if (wj.d == UiSize.Classic)
		{
			if (egg.v)
			{
				a_ = egg.q;
				a_2 = egg.n;
			}
			else
			{
				a_ = egg.am;
				a_2 = egg.z;
			}
		}
		else
		{
			a_ = cq4.c();
			a_2 = cq4.b();
		}
		if (A_0 == this.i)
		{
			float num;
			if (this.i.wh() == 0f)
			{
				num = 0f;
			}
			else
			{
				num = this.i.wj() / this.i.wh();
			}
			Color darkGray;
			if (this.i.wj() <= 0f)
			{
				darkGray = Color.DarkGray;
			}
			else
			{
				darkGray = new Color(1f - num * 0.75f, num * 0.75f, 0f);
			}
			ecs ecs = new ecs(new List<dl6>
			{
				new dl6(new List<bph>
				{
					new bph(new d22(a_, Color.White), "Здоровье: ", null),
					new bph(new d22(a_, darkGray), ((int)this.i.wj()).ToString(), null),
					new bph(new d22(a_, Color.White), " / ", null),
					new bph(new d22(a_, Color.LightGray), ((int)this.i.wh()).ToString(), null),
					new bph(new d22(a_, Color.White), " (", null),
					new bph(new d22(a_, darkGray), string.Format("{0}%", (int)Math.Ceiling((double)(this.i.wj() / this.i.wh() * 100f))), null),
					new bph(new d22(a_, Color.White), ")", null)
				})
			});
			if (this.n != null && this.n.Defense.x())
			{
				ecs.a.Add(new dl6(new List<bph>
				{
					new bph(new d22(a_2, Color.LightGray), "(регенерация)", null)
				}));
			}
			return ecs;
		}
		if (A_0 == this.k)
		{
			return new ecs(new List<dl6>
			{
				new dl6(new List<bph>
				{
					new bph(new d22(a_, Color.White), "Щит: ", null),
					new bph(new d22(a_, Color.LightBlue), ((int)this.k.wj()).ToString(), null),
					new bph(new d22(a_, Color.White), " / ", null),
					new bph(new d22(a_, Color.LightGray), ((int)this.k.wh()).ToString(), null)
				})
			});
		}
		if (A_0 == this.j)
		{
			ecs ecs2 = new ecs(new List<dl6>
			{
				new dl6(new List<bph>
				{
					new bph(new d22(a_, Color.White), "Пси: ", null),
					new bph(new d22(a_, adi.f), ((int)((this.j.a != null) ? this.j.a.zo() : 0f)).ToString(), null),
					new bph(new d22(a_, Color.White), " / ", null),
					new bph(new d22(a_, Color.LightGray), ((int)((this.j.a != null) ? this.j.a.zm() : 0f)).ToString(), null),
					new bph(new d22(a_, Color.White), " (", null),
					new bph(new d22(a_, adi.f), string.Format("{0}{1}", (this.j().Offense.ao() < 0) ? "-" : "+", Math.Abs(this.j().Offense.ao())), null),
					new bph(new d22(a_, Color.White), ")", null)
				})
			});
			if (this.j.b != null)
			{
				ecs2.a.Add(new dl6(new List<bph>
				{
					new bph(new d22(a_, Color.White), "Пси-резерв: ", null),
					new bph(new d22(a_, adi.f), ((int)this.j.b.zo()).ToString(), null),
					new bph(new d22(a_, Color.White), " / ", null),
					new bph(new d22(a_, Color.LightGray), ((int)this.j.b.zm()).ToString(), null)
				}));
			}
			return ecs2;
		}
		if (A_0 == this.h)
		{
			ecs ecs3 = new ecs();
			if (this.y && this.n != null && this.n.IsInCombat)
			{
				dl6 item = new dl6(new List<bph>
				{
					new bph(new d22(cq4.d(), Color.Red), "В бою", null)
				});
				dl6 item2 = new dl6(new List<bph>
				{
					new bph(new d22(cq4.c(), Color.LightGray), "Пока ваш персонаж в бою, некоторые действия могут быть недоступны. Бой закончится вскоре после прекращения враждебных действий.", null)
				});
				ecs3.a.Add(item);
				ecs3.a.Add(item2);
			}
			if (this.x && this.n != null && this.n.Offense.af())
			{
				dl6 item3 = new dl6(new List<bph>
				{
					new bph(new d22(cq4.c(), Color.LightGray), "", null)
				});
				dl6 item4 = new dl6(new List<bph>
				{
					new bph(new d22(cq4.d(), adi.c), "Сосредоточенность", null)
				});
				dl6 item5 = new dl6(new List<bph>
				{
					new bph(new d22(cq4.c(), Color.LightGray), "Ваш персонаж полностью сосредоточен, что повышает его умения в дальнем бою. Сосредоточение теряется при перемещении.", null)
				});
				if (ecs3.a.Count > 0)
				{
					ecs3.a.Add(item3);
				}
				ecs3.a.Add(item4);
				ecs3.a.Add(item5);
			}
			return ecs3;
		}
		if (this.w && A_0 == this.m)
		{
			ecs ecs4 = new ecs();
			dl6 item6 = new dl6(new List<bph>
			{
				new bph(new d22(cq4.d(), adi.c), "Повышение уровня", null)
			});
			dl6 item7 = new dl6(new List<bph>
			{
				new bph(new d22(cq4.c(), Color.LightGray), "Ваш персонаж заработал достаточно опыта, чтобы повысить уровень.", null)
			});
			dl6 item8 = new dl6(new List<bph>
			{
				new bph(new d22(cq4.c(), Color.LightGray), "Щёлкните левой кнопкой мыши, чтобы повысить уровень.", null)
			});
			ecs4.a.Add(item6);
			ecs4.a.Add(item7);
			ecs4.a.Add(item8);
			return ecs4;
		}
		if (this.z)
		{
			if ((A_0 == this.ac || A_0 == this.af) && this.aa != dl5.BrokenItemNotificationState.None)
			{
				ecs ecs5 = new ecs();
				dl6 item9 = new dl6(new List<bph>
				{
					new bph(new d22(cq4.d(), (this.aa == dl5.BrokenItemNotificationState.Broken) ? Color.Red : Color.Orange), (this.aa == dl5.BrokenItemNotificationState.Broken) ? "Сильно повреждена броня" : "Повреждена броня", null)
				});
				dl6 item10 = new dl6(new List<bph>
				{
					new bph(new d22(cq4.c(), Color.LightGray), (this.aa == dl5.BrokenItemNotificationState.Broken) ? "Одна из частей вашей брони повреждена и не даёт бонусов брони до проведения ремонта." : "Одна из частей вашей брони повреждена и даёт уменьшенные бонусы брони до проведения ремонта.", null)
				});
				ecs5.a.Add(item9);
				ecs5.a.Add(item10);
				return ecs5;
			}
			if ((A_0 == this.ad || A_0 == this.ag) && this.ab != dl5.BrokenItemNotificationState.None)
			{
				ecs ecs6 = new ecs();
				dl6 item11 = new dl6(new List<bph>
				{
					new bph(new d22(cq4.d(), (this.ab == dl5.BrokenItemNotificationState.Broken) ? Color.Red : Color.Orange), (this.ab == dl5.BrokenItemNotificationState.Broken) ? "Оружие сильно изношено" : "Оружие изношено", null)
				});
				dl6 item12 = new dl6(new List<bph>
				{
					new bph(new d22(cq4.c(), Color.LightGray), (this.ab == dl5.BrokenItemNotificationState.Broken) ? "Ваше оружие изношено из-за частого использования, и до проведения ремонта у него сильно снижена точность." : "Ваше оружие изношено из-за частого использования, и до проведения ремонта у него снижена точность.", null)
				});
				ecs6.a.Add(item11);
				ecs6.a.Add(item12);
				return ecs6;
			}
			if (this.n != null && ((A_0 == this.ae && this.ae.Visible) || (A_0 == this.ah && this.ah.Visible)))
			{
				Color a_3;
				string a_4;
				string a_5;
				switch (this.n.EncumbranceLevel)
				{
				default:
					a_3 = Color.Black;
					a_4 = null;
					a_5 = null;
					break;
				case db9.b:
					a_3 = Color.Orange;
					a_4 = "Легко перегружены";
					a_5 = "Вы слишком много несёте, из-за чего страдает ваша скорость передвижения, уменьшен запас очков движения и возможно даже очков действия.";
					break;
				case db9.c:
					a_3 = Color.OrangeRed;
					a_4 = "Сильно перегружены";
					a_5 = "Вы ну очень уж много несёте, из-за чего страдает ваша скорость передвижения, уменьшен запас очков движения и возможно даже очков действия.";
					break;
				case db9.d:
					a_4 = "Перегруженность";
					a_3 = Color.Red;
					a_5 = "На вас так много барахла, что вы не можете двигаться. От этого также может страдать запас очков действия.";
					break;
				}
				ecs ecs7 = new ecs();
				dl6 item13 = new dl6(new List<bph>
				{
					new bph(new d22(cq4.d(), a_3), a_4, null)
				});
				dl6 item14 = new dl6(new List<bph>
				{
					new bph(new d22(cq4.c(), Color.LightGray), a_5, null)
				});
				ecs7.a.Add(item13);
				ecs7.a.Add(item14);
				return ecs7;
			}
		}
		return null;
	}

	// Token: 0x0600C54D RID: 50509 RVA: 0x0044E6FC File Offset: 0x0044C8FC
	private void t(object A_0, b25 A_1)
	{
		if (this.al != null)
		{
			this.al(this, A_1);
		}
	}

	// Token: 0x0600C54E RID: 50510 RVA: 0x0044E71C File Offset: 0x0044C91C
	private void s(object A_0, b25 A_1)
	{
		ps service = bpo.GetService<ps>();
		if (service != null)
		{
			service.amr(true, null, false);
		}
	}

	// Token: 0x0600C54F RID: 50511 RVA: 0x0044E748 File Offset: 0x0044C948
	private void r(object A_0, b25 A_1)
	{
		if (this.am != null)
		{
			this.am(this, A_1);
		}
	}

	// Token: 0x0600C550 RID: 50512 RVA: 0x0044E764 File Offset: 0x0044C964
	private void q(object A_0, b25 A_1)
	{
		this.p.b();
	}

	// Token: 0x0600C551 RID: 50513 RVA: 0x0044E774 File Offset: 0x0044C974
	private void p(object A_0, b25 A_1)
	{
		this.p.b();
	}

	// Token: 0x0600C552 RID: 50514 RVA: 0x0044E784 File Offset: 0x0044C984
	private void o(object A_0, b25 A_1)
	{
		this.s.b();
	}

	// Token: 0x0600C553 RID: 50515 RVA: 0x0044E794 File Offset: 0x0044C994
	private void n(object A_0, b25 A_1)
	{
		this.s.b();
	}

	// Token: 0x0600C554 RID: 50516 RVA: 0x0044E7A4 File Offset: 0x0044C9A4
	private void m(object A_0, b25 A_1)
	{
		if (A_1.b() == eoo.b)
		{
			bpo.GetServiceOrThrow<ps>().am2();
		}
	}

	// Token: 0x0600C555 RID: 50517 RVA: 0x0044E7BC File Offset: 0x0044C9BC
	private void l(object A_0, b25 A_1)
	{
		this.o.b();
	}

	// Token: 0x0600C556 RID: 50518 RVA: 0x0044E7CC File Offset: 0x0044C9CC
	private void k(object A_0, b25 A_1)
	{
		this.o.b();
	}

	// Token: 0x0600C557 RID: 50519 RVA: 0x0044E7DC File Offset: 0x0044C9DC
	private void j(object A_0, b25 A_1)
	{
		this.q.b();
	}

	// Token: 0x0600C558 RID: 50520 RVA: 0x0044E7EC File Offset: 0x0044C9EC
	private void i(object A_0, b25 A_1)
	{
		this.q.b();
	}

	// Token: 0x0600C559 RID: 50521 RVA: 0x0044E7FC File Offset: 0x0044C9FC
	private void h(object A_0, b25 A_1)
	{
		this.r.b();
	}

	// Token: 0x0600C55A RID: 50522 RVA: 0x0044E80C File Offset: 0x0044CA0C
	private void g(object A_0, b25 A_1)
	{
		this.r.b();
	}

	// Token: 0x0600C55B RID: 50523 RVA: 0x0044E81C File Offset: 0x0044CA1C
	private void f(object A_0, b25 A_1)
	{
		this.u.b();
	}

	// Token: 0x0600C55C RID: 50524 RVA: 0x0044E82C File Offset: 0x0044CA2C
	private void e(object A_0, b25 A_1)
	{
		this.u.b();
	}

	// Token: 0x0600C55D RID: 50525 RVA: 0x0044E83C File Offset: 0x0044CA3C
	private void d(object A_0, b25 A_1)
	{
		this.t.b();
	}

	// Token: 0x0600C55E RID: 50526 RVA: 0x0044E84C File Offset: 0x0044CA4C
	private void c(object A_0, b25 A_1)
	{
		this.t.b();
	}

	// Token: 0x0600C55F RID: 50527 RVA: 0x0044E85C File Offset: 0x0044CA5C
	private void b(object A_0, b25 A_1)
	{
		this.v.b();
	}

	// Token: 0x0600C560 RID: 50528 RVA: 0x0044E86C File Offset: 0x0044CA6C
	private void a(object A_0, b25 A_1)
	{
		this.v.b();
	}

	// Token: 0x0600C561 RID: 50529 RVA: 0x0044E87C File Offset: 0x0044CA7C
	private void h()
	{
		this.d();
		this.g();
		this.c();
		this.a();
	}

	// Token: 0x0600C562 RID: 50530 RVA: 0x0044E898 File Offset: 0x0044CA98
	private void g()
	{
		this.o = new dsy(this.i, this, esj.a(), 0, null, null, 300, false, false);
		this.p = new dsy(this.k, this, esj.a(), 0, null, null, 300, false, false);
		this.q = new dsy(this.j, this, esj.a(), 0, null, null, 300, false, false);
		this.r = new dsy(this.h, this, esj.a(), 300, null, null, 300, false, false);
		this.s = new dsy(this.m, this, esj.a(), 0, null, null, 1000, false, false);
		if (this.ac != null)
		{
			this.t = new dsy(this.ac, this, esj.a(), 300, null, null, 500, false, false);
		}
		else if (this.af != null)
		{
			this.t = new dsy(this.af, this, esj.a(), 300, null, null, 500, false, false);
		}
		if (this.ad != null)
		{
			this.u = new dsy(this.ad, this, esj.a(), 300, null, null, 500, false, false);
		}
		else if (this.ag != null)
		{
			this.u = new dsy(this.ag, this, esj.a(), 300, null, null, 500, false, false);
		}
		if (this.ae != null)
		{
			this.v = new dsy(this.ae, this, esj.a(), 300, null, null, 500, false, false);
			return;
		}
		if (this.ah != null)
		{
			this.v = new dsy(this.ah, this, esj.a(), 300, null, null, 500, false, false);
		}
	}

	// Token: 0x0600C563 RID: 50531 RVA: 0x0044EB2C File Offset: 0x0044CD2C
	private void f()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		int num = 300;
		if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Huge)
		{
			num = (int)((double)num * 2.5);
		}
		else if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.ExtraLarge)
		{
			num *= 2;
		}
		else if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Large)
		{
			num = (int)((double)num * 1.5);
		}
		if (this.r != null)
		{
			this.r.a(num);
		}
		if (this.t != null)
		{
			this.t.a(num);
		}
		if (this.u != null)
		{
			this.u.a(num);
		}
		if (this.v != null)
		{
			this.v.a(num);
		}
	}

	// Token: 0x0600C564 RID: 50532 RVA: 0x0044EC10 File Offset: 0x0044CE10
	private string e()
	{
		bi3 service = bpo.GetService<bi3>();
		if (service == null || service.aij() == null || service.aij().eg() == null)
		{
			return TimelapseCursor.Default.ToString();
		}
		if (this.aj != null && service.aij().eg().cg(this.aj))
		{
			return TimelapseCursor.InvokeSpell.ToString();
		}
		return TimelapseCursor.Impossible.ToString();
	}

	// Token: 0x0600C565 RID: 50533 RVA: 0x0044EC9C File Offset: 0x0044CE9C
	private void d()
	{
		wj wj = wj.a();
		if (wj.d == UiSize.Classic)
		{
			this.h = new apw(bd8.b);
			apw apw = this.h;
			apw.Size = esj.b(apw.Size, (double)this.f);
		}
		else
		{
			this.a.d = wj.bt.d;
			this.h = new apw((bd8)wj.h);
			apw apw2 = this.h;
			apw2.Size = esj.b(apw2.Size, (double)this.f);
		}
		this.h.p(new EventHandler<b25>(this.t));
		this.h.i(new EventHandler<b25>(this.s));
		this.h.j(new EventHandler<b25>(this.g));
		this.h.l(new EventHandler<b25>(this.h));
		this.h.n = new Func<string>(this.e);
		this.aox(this.h);
		this.i = new ex4();
		this.i.Location = new Point(0, this.h.Size.d + 3);
		this.i.Size = new esj(this.h.Size.c, this.a.d);
		this.i.Color = Color.Red;
		this.i.j(new EventHandler<b25>(this.k));
		this.i.l(new EventHandler<b25>(this.l));
		this.i.a(5);
		this.aox(this.i);
		this.j = new aww();
		this.j.Size = new esj(this.h.Size.c, this.a.d);
		this.j.Color = adi.f;
		this.j.i = new Color(219, 109, 255);
		this.j.j(new EventHandler<b25>(this.i));
		this.j.l(new EventHandler<b25>(this.j));
		this.j.h = 5;
		this.aox(this.j);
		this.k = new ex4();
		this.k.Location = new Point(0, this.h.Size.d + this.a.d + 6);
		this.k.Size = new esj(this.h.Size.c, this.a.d);
		this.k.Color = adi.al;
		this.k.j(new EventHandler<b25>(this.p));
		this.k.l(new EventHandler<b25>(this.q));
		this.k.a(5);
		this.aox(this.k);
		this.l = new a0d(this.n, new esj(10, 3), 0.75f);
		this.l.Location = new Point(this.h.Location.X + this.h.Size.c + 6, 0);
		this.aox(this.l);
		this.m = new bg1();
		if (wj.d == UiSize.Classic)
		{
			this.m.b = bo1.bo;
			this.m.d = new Rectangle?(new Rectangle(40, 0, 24, 24));
			this.m.Size = new esj(24, 24);
			this.m.Location = new Point(this.h.Location.X + this.h.Size.c - this.m.Size.c - 7, 7);
		}
		else
		{
			this.m.b = wj.f;
			this.m.d = new Rectangle?(new Rectangle(wj.bg.X + 2 * wj.bh.c, wj.bg.Y, wj.bh.c, wj.bh.d));
			this.m.Size = new esj(wj.bh.c, wj.bh.d);
			this.m.Location = new Point(this.h.Location.X + this.h.Size.c - this.m.Size.c - wj.i, wj.i);
		}
		this.m.j(new EventHandler<b25>(this.n));
		this.m.l(new EventHandler<b25>(this.o));
		this.m.p(new EventHandler<b25>(this.m));
		this.aox(this.m);
		base.Size = new esj(this.l.Location.X + this.l.Size.c, this.h.Size.d + 3 * (3 + this.a.d) + 3 + 35 + 150);
		if (wj.d == UiSize.Classic)
		{
			this.ae = new bi();
			this.ae.j(new EventHandler<b25>(this.a));
			this.ae.l(new EventHandler<b25>(this.b));
			this.aox(this.ae);
			this.ac = new bi();
			this.ac.Location = new Point(40, 0);
			this.ac.j(new EventHandler<b25>(this.c));
			this.ac.l(new EventHandler<b25>(this.d));
			this.aox(this.ac);
			this.ad = new bi();
			this.ad.Location = new Point(80, 0);
			this.ad.j(new EventHandler<b25>(this.e));
			this.ad.l(new EventHandler<b25>(this.f));
			this.aox(this.ad);
			this.ad.Visible = true;
		}
		else
		{
			this.ah = new bg1();
			this.ah.b = wj.f;
			this.ah.j(new EventHandler<b25>(this.a));
			this.ah.l(new EventHandler<b25>(this.b));
			this.ah.Size = wj.bk;
			this.ah.Visible = false;
			this.aox(this.ah);
			this.af = new bg1();
			this.af.b = wj.f;
			this.af.Location = new Point(wj.bk.c, 0);
			this.af.j(new EventHandler<b25>(this.c));
			this.af.l(new EventHandler<b25>(this.d));
			this.af.Size = wj.bk;
			this.af.Visible = false;
			this.aox(this.af);
			this.ag = new bg1();
			this.ag.b = wj.f;
			this.ag.Location = new Point(wj.bk.c * 2, 0);
			this.ag.j(new EventHandler<b25>(this.e));
			this.ag.l(new EventHandler<b25>(this.f));
			this.ag.Size = wj.bk;
			this.ag.Visible = false;
			this.aox(this.ag);
		}
		if (wj.d == UiSize.Classic)
		{
			this.ak = new c9p(this.n, this.g ? bd8.b : bd8.a);
		}
		else
		{
			this.ak = new c9p(this.n, (bd8)(this.g ? wj.l : wj.m));
		}
		this.ak.Visible = false;
		this.ak.a(new EventHandler<b25>(this.r));
		this.aox(this.ak);
	}

	// Token: 0x0600C566 RID: 50534 RVA: 0x0044F57C File Offset: 0x0044D77C
	private void c()
	{
		if (this.n == null)
		{
			this.h.a(null);
			this.i.a(null);
			this.k.a(null);
			this.l.a(null);
			this.ak.e = null;
			return;
		}
		this.h.a(this.n.bd);
		this.i.a(this.n.Defense.q());
		this.k.a(new dl5.a(this.n.Defense));
		this.j.a = this.n.Offense.aa();
		wj wj = wj.a();
		if (wj.d == UiSize.Classic)
		{
			if (this.n is e3q)
			{
				this.j.b = this.n.Offense.ab();
				this.j.c = bo1.g;
				this.j.d = bo1.h;
			}
			else
			{
				this.j.b = null;
				this.j.c = bo1.f;
				this.j.d = null;
			}
		}
		else if (this.n is e3q)
		{
			this.j.b = this.n.Offense.ab();
			this.j.c = wj.f;
			this.j.e = new Point(wj.bs.X + wj.bt.c, wj.bs.Y);
			this.j.d = wj.f;
			this.j.f = new Point(wj.bs.X + 2 * wj.bt.c, wj.bs.Y);
			this.j.g = new esj?(wj.bt);
		}
		else
		{
			this.j.b = null;
			this.j.c = wj.f;
			this.j.e = new Point(wj.bs.X, wj.bs.Y);
			this.j.d = null;
			this.j.g = new esj?(wj.bt);
		}
		this.l.a(this.n);
		this.ak.e = this.n;
	}

	// Token: 0x0600C567 RID: 50535 RVA: 0x0044F81C File Offset: 0x0044DA1C
	private void b()
	{
	}

	// Token: 0x0600C568 RID: 50536 RVA: 0x0044F820 File Offset: 0x0044DA20
	private void a()
	{
		if (this.n != null)
		{
			this.k.Visible = (this.k.a() != null && this.k.a().zm() > 0f);
			if (this.n.PsiEmpathy)
			{
				this.j.Visible = true;
				if (!this.k.Visible)
				{
					this.j.Location = this.k.Location;
				}
				else
				{
					this.j.Location = new Point(0, this.k.Location.Y + this.k.Size.d + 3);
				}
			}
			else
			{
				this.j.Visible = false;
			}
			e3q e3q = this.n as e3q;
			this.m.Visible = (this.w && c2h.a(e3q) && e3q.Portrait != "power_suit");
			int num;
			if (this.j.Visible)
			{
				num = this.j.Location.Y;
			}
			else if (this.k.Visible)
			{
				num = this.k.Location.Y;
			}
			else
			{
				num = this.i.Location.Y;
			}
			num += this.a.d + 3;
			if (this.ac != null)
			{
				this.ac.Location = new Point(this.ac.Location.X, num);
				this.ad.Location = new Point(this.ad.Location.X, num);
				this.ae.Location = new Point(this.ae.Location.X, num);
			}
			else
			{
				this.af.Location = new Point(this.af.Location.X, num);
				this.ag.Location = new Point(this.ag.Location.X, num);
				this.ah.Location = new Point(this.ah.Location.X, num);
			}
			int num2;
			if (this.g)
			{
				num2 = num + 50;
			}
			else
			{
				num2 = num + 20;
			}
			this.ak.Location = new Point(0, num2);
		}
	}

	// Token: 0x0600C569 RID: 50537 RVA: 0x0044FAB0 File Offset: 0x0044DCB0
	private dl5.BrokenItemNotificationState a(coh A_0)
	{
		double num = A_0.Durability / (double)A_0.MaxDurability;
		if (num < dwh.i)
		{
			return dl5.BrokenItemNotificationState.Broken;
		}
		if (num < dwh.h)
		{
			return dl5.BrokenItemNotificationState.Damaged;
		}
		return dl5.BrokenItemNotificationState.None;
	}

	// Token: 0x04004840 RID: 18496
	private new esj a = new esj(110, 15);

	// Token: 0x04004841 RID: 18497
	private new esj b = new esj(18, 18);

	// Token: 0x04004842 RID: 18498
	private new const int c = 3;

	// Token: 0x04004843 RID: 18499
	private new const int d = 0;

	// Token: 0x04004844 RID: 18500
	private new const int e = 1;

	// Token: 0x04004845 RID: 18501
	private new float f;

	// Token: 0x04004846 RID: 18502
	private new bool g;

	// Token: 0x04004847 RID: 18503
	private apw h;

	// Token: 0x04004848 RID: 18504
	private ex4 i;

	// Token: 0x04004849 RID: 18505
	private new aww j;

	// Token: 0x0400484A RID: 18506
	private new ex4 k;

	// Token: 0x0400484B RID: 18507
	private new a0d l;

	// Token: 0x0400484C RID: 18508
	private new bg1 m;

	// Token: 0x0400484D RID: 18509
	private efk n;

	// Token: 0x0400484E RID: 18510
	private dsy o;

	// Token: 0x0400484F RID: 18511
	private dsy p;

	// Token: 0x04004850 RID: 18512
	private dsy q;

	// Token: 0x04004851 RID: 18513
	private dsy r;

	// Token: 0x04004852 RID: 18514
	private dsy s;

	// Token: 0x04004853 RID: 18515
	private dsy t;

	// Token: 0x04004854 RID: 18516
	private dsy u;

	// Token: 0x04004855 RID: 18517
	private dsy v;

	// Token: 0x04004856 RID: 18518
	private bool w = true;

	// Token: 0x04004857 RID: 18519
	private bool x = true;

	// Token: 0x04004858 RID: 18520
	private bool y = true;

	// Token: 0x04004859 RID: 18521
	private bool z = true;

	// Token: 0x0400485A RID: 18522
	private dl5.BrokenItemNotificationState aa;

	// Token: 0x0400485B RID: 18523
	private dl5.BrokenItemNotificationState ab;

	// Token: 0x0400485C RID: 18524
	private bi ac;

	// Token: 0x0400485D RID: 18525
	private bi ad;

	// Token: 0x0400485E RID: 18526
	private bi ae;

	// Token: 0x0400485F RID: 18527
	private new bg1 af;

	// Token: 0x04004860 RID: 18528
	private bg1 ag;

	// Token: 0x04004861 RID: 18529
	private bg1 ah;

	// Token: 0x04004862 RID: 18530
	private bool ai;

	// Token: 0x04004863 RID: 18531
	private c5x aj;

	// Token: 0x04004864 RID: 18532
	private c9p ak;

	// Token: 0x04004865 RID: 18533
	[CompilerGenerated]
	private EventHandler<b25> al;

	// Token: 0x04004866 RID: 18534
	[CompilerGenerated]
	private new EventHandler<b25> am;

	// Token: 0x02002065 RID: 8293
	private enum BrokenItemNotificationState
	{
		// Token: 0x04004868 RID: 18536
		None,
		// Token: 0x04004869 RID: 18537
		Damaged,
		// Token: 0x0400486A RID: 18538
		Broken
	}

	// Token: 0x02002066 RID: 8294
	private new sealed class a : IBoundVariable<float>
	{
		// Token: 0x0600C56A RID: 50538 RVA: 0x0044FAE8 File Offset: 0x0044DCE8
		public a(nw A_0)
		{
			this.a = A_0;
		}

		// Token: 0x0600C56B RID: 50539 RVA: 0x0044FAF8 File Offset: 0x0044DCF8
		public float zk()
		{
			return 0f;
		}

		// Token: 0x0600C56C RID: 50540 RVA: 0x0044FB00 File Offset: 0x0044DD00
		public void zl(float A_0)
		{
		}

		// Token: 0x0600C56D RID: 50541 RVA: 0x0044FB04 File Offset: 0x0044DD04
		public float zm()
		{
			return (float)this.a.p();
		}

		// Token: 0x0600C56E RID: 50542 RVA: 0x0044FB14 File Offset: 0x0044DD14
		public void zn(float A_0)
		{
		}

		// Token: 0x0600C56F RID: 50543 RVA: 0x0044FB18 File Offset: 0x0044DD18
		public float zo()
		{
			return (float)this.a.i5();
		}

		// Token: 0x0600C570 RID: 50544 RVA: 0x0044FB28 File Offset: 0x0044DD28
		public void zp(float A_0)
		{
		}

		// Token: 0x0600C571 RID: 50545 RVA: 0x0044FB2C File Offset: 0x0044DD2C
		[CompilerGenerated]
		public void zq(EventHandler<c1> A_0)
		{
			EventHandler<c1> eventHandler = this.b;
			EventHandler<c1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.b, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600C572 RID: 50546 RVA: 0x0044FB64 File Offset: 0x0044DD64
		[CompilerGenerated]
		public void zr(EventHandler<c1> A_0)
		{
			EventHandler<c1> eventHandler = this.b;
			EventHandler<c1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.b, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600C573 RID: 50547 RVA: 0x0044FB9C File Offset: 0x0044DD9C
		[CompilerGenerated]
		public void zs(EventHandler<c1> A_0)
		{
			EventHandler<c1> eventHandler = this.c;
			EventHandler<c1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.c, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600C574 RID: 50548 RVA: 0x0044FBD4 File Offset: 0x0044DDD4
		[CompilerGenerated]
		public void zt(EventHandler<c1> A_0)
		{
			EventHandler<c1> eventHandler = this.c;
			EventHandler<c1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.c, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600C575 RID: 50549 RVA: 0x0044FC0C File Offset: 0x0044DE0C
		[CompilerGenerated]
		public void zu(EventHandler<c1> A_0)
		{
			EventHandler<c1> eventHandler = this.d;
			EventHandler<c1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.d, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600C576 RID: 50550 RVA: 0x0044FC44 File Offset: 0x0044DE44
		[CompilerGenerated]
		public void zv(EventHandler<c1> A_0)
		{
			EventHandler<c1> eventHandler = this.d;
			EventHandler<c1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.d, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0400486B RID: 18539
		private nw a;

		// Token: 0x0400486C RID: 18540
		[CompilerGenerated]
		private EventHandler<c1> b;

		// Token: 0x0400486D RID: 18541
		[CompilerGenerated]
		private EventHandler<c1> c;

		// Token: 0x0400486E RID: 18542
		[CompilerGenerated]
		private EventHandler<c1> d;
	}
}
