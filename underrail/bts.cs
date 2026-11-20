using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Common;
using TimelapseVertigo.Common.Settings;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;
using TimelapseVertigo.UI.Controls;

// Token: 0x02002063 RID: 8291
public sealed class bts : euz
{
	// Token: 0x0600C52A RID: 50474 RVA: 0x0044BFBC File Offset: 0x0044A1BC
	public bts(efk A_0, b3w A_1, euz A_2, Func<coh> A_3)
	{
		czh.a(A_0, "character");
		czh.a(A_1, "bagView");
		this.j = A_1;
		this.k = A_0;
		this.v = A_2;
		this.w = A_3;
		this.c();
	}

	// Token: 0x0600C52B RID: 50475 RVA: 0x0044C058 File Offset: 0x0044A258
	private void c()
	{
		wj wj = wj.a();
		this.l = new bg1();
		if (wj.d == UiSize.Classic)
		{
			this.l.b = bo1.bu;
			this.l.Size = new esj(160, 360);
			this.l.Location = new Point(55, 1);
		}
		else
		{
			this.l.b = string.Format(bo1.bv, bl9.a(wj.d));
			this.l.d = new Rectangle?(new Rectangle((this.k != null && this.k.Gender == Gender.Female) ? wj.ck.c : 0, 0, wj.ck.c, wj.ck.d));
			this.l.Size = wj.ck;
			this.l.Location = wj.cl;
			this.c = this.l.Location.X + this.l.Size.c / 2 - wj.cs.c / 2;
			this.i = (int)(0.078125 * (double)this.l.Size.d) - wj.cs.d / 2;
			this.h = new Point((int)(0.29 * (double)this.l.Size.c), (int)(0.2 * (double)this.l.Size.d) - wj.cs.d / 2);
			this.d = new Point((int)(0.38 * (double)this.l.Size.c), (int)(0.55 * (double)this.l.Size.d) - wj.cs.d / 2);
			this.e = (int)(0.277 * (double)this.l.Size.d) - wj.cs.d / 2;
			this.f = (int)(0.45 * (double)this.l.Size.d) - wj.cs.d / 2;
			this.g = (int)(0.9 * (double)this.l.Size.d) - wj.cs.d / 2;
		}
		this.l.a = false;
		this.l.Ghost = true;
		this.aox(this.l);
		base.Size = new esj(this.l.Location.X + this.l.Size.c + 15, this.l.Location.Y + this.l.Size.d);
		this.b();
		this.a();
	}

	// Token: 0x0600C52C RID: 50476 RVA: 0x0044C380 File Offset: 0x0044A580
	private void b()
	{
		int num = 13;
		wj wj = wj.a();
		if (wj.d != UiSize.Classic)
		{
			num = (int)((double)wj.cs.d * 0.35);
		}
		this.m = new List<b75>();
		for (int i = 0; i < aiy.ay; i++)
		{
			b75 b = this.a(i);
			b.Location = new Point(10, 40 + i * (b.f.d + num));
			this.m.Add(b);
		}
	}

	// Token: 0x0600C52D RID: 50477 RVA: 0x0044C40C File Offset: 0x0044A60C
	private void a()
	{
		this.n = new List<cqy>();
		this.o = this.CreateGearSlot<k7>(this.k.Gear.g(), dh9.c("CharInventory_GearSlot_Headgear"), 4);
		this.o.Location = new Point(this.c, this.i);
		this.n.Add(this.o);
		this.p = this.CreateGearSlot<cgd>(this.k.Gear.h(), dh9.c("CharInventory_GearSlot_EnergyShieldEmitter"), 5);
		this.p.Location = new Point(this.c + this.h.X, this.h.Y);
		this.n.Add(this.p);
		this.q = this.CreateGearSlot<c8d>(this.k.Gear.l(), dh9.c("CharInventory_GearSlot_Armor"), 1);
		this.q.Location = new Point(this.c, this.e);
		this.n.Add(this.q);
		this.r = this.CreateGearSlot<cjh>(this.k.Gear.e(), dh9.c("CharInventory_GearSlot_Belt"), 2);
		this.r.Location = new Point(this.c, this.f);
		this.n.Add(this.r);
		this.s = this.CreateGearSlot<a12>(this.k.Gear.f(), dh9.c("CharInventory_GearSlot_Footwear"), 3);
		this.s.Location = new Point(this.c, this.g);
		this.n.Add(this.s);
		this.t = this.CreateGearSlot<cd1>(this.k.Gear.j()[WeaponKey.Primary], dh9.c("CharInventory_GearSlot_PrimaryWeapon"), 0);
		this.t.Location = new Point(this.c - this.d.X, this.d.Y);
		this.n.Add(this.t);
		this.u = this.CreateGearSlot<cd1>(this.k.Gear.j()[WeaponKey.Secondary], dh9.c("CharInventory_GearSlot_SecondaryWeapon"), 0);
		this.u.Location = new Point(this.c + this.d.X, this.d.Y);
		this.n.Add(this.u);
	}

	// Token: 0x0600C52E RID: 50478 RVA: 0x0044C6B0 File Offset: 0x0044A8B0
	private b75 a(int A_0)
	{
		wj wj = wj.a();
		b75 b;
		if (wj.d == UiSize.Classic)
		{
			b = new b75(this.k.Gear.d()[A_0], dh9.c("CharInventory_GearSlot_CombatUtility"));
		}
		else
		{
			b = new b75(this.k.Gear.d()[A_0], dh9.c("CharInventory_GearSlot_CombatUtility"), wj.cs, wj.o);
			b.d = wj.f;
			b.e = wj.cr;
			b.h = new Vector2?(wj.w);
			b.i = wj.x;
			b.a(Color.Black);
			b.b = new Rectangle(wj.co.X, wj.co.Y, wj.cp.c, wj.cp.d);
			b.c = new Rectangle(wj.co.X + 2 * wj.cp.c, wj.co.Y, wj.cp.c, wj.cp.d);
			b.u = true;
			b.b = 6;
			b.r = wj.s;
		}
		b.Color = new Color(128, 26, 0);
		b.Name = "CharacterQuickSlotName";
		b.b(false);
		b.x9(ItemExchangeParty.PlayerGear.ToString());
		b.Name = "quickSlot";
		b.a(this.v);
		b.a(this.w);
		b.p(new EventHandler<b25>(this.b));
		b.i(new EventHandler<b25>(this.a));
		this.b(b);
		return b;
	}

	// Token: 0x0600C52F RID: 50479 RVA: 0x0044C88C File Offset: 0x0044AA8C
	private PlayerGearItemSlotControl<T> CreateGearSlot<T>(ItemSlot<T> itemSlot, string tooltipCaption, int backgroundOrdinal = -1) where T : coh
	{
		wj wj = wj.a();
		PlayerGearItemSlotControl<T> playerGearItemSlotControl;
		if (wj.d == UiSize.Classic)
		{
			playerGearItemSlotControl = new PlayerGearItemSlotControl<T>(itemSlot, tooltipCaption);
		}
		else
		{
			playerGearItemSlotControl = new PlayerGearItemSlotControl<T>(itemSlot, tooltipCaption, wj.cs, wj.o);
			playerGearItemSlotControl.d = wj.f;
			playerGearItemSlotControl.e = wj.cr;
			playerGearItemSlotControl.h = new Vector2?(wj.w);
			playerGearItemSlotControl.i = wj.x;
			playerGearItemSlotControl.a(Color.Black);
			playerGearItemSlotControl.b = new Rectangle(wj.co.X, wj.co.Y, wj.cp.c, wj.cp.d);
			playerGearItemSlotControl.c = new Rectangle(wj.co.X + 2 * wj.cp.c, wj.co.Y, wj.cp.c, wj.cp.d);
			playerGearItemSlotControl.u = true;
			playerGearItemSlotControl.b = backgroundOrdinal;
			playerGearItemSlotControl.r = wj.s;
		}
		playerGearItemSlotControl.Color = new Color(0, 74, 37);
		playerGearItemSlotControl.Name = "CharacterGearSlot";
		playerGearItemSlotControl.x9(ItemExchangeParty.PlayerGear.ToString());
		playerGearItemSlotControl.a(this.v);
		playerGearItemSlotControl.a(this.w);
		playerGearItemSlotControl.p(new EventHandler<b25>(this.b));
		playerGearItemSlotControl.i(new EventHandler<b25>(this.a));
		if (typeof(T) == typeof(cd1))
		{
			playerGearItemSlotControl.Name = "weaponSlot";
			playerGearItemSlotControl.b(false);
		}
		if (typeof(T) == typeof(c8d))
		{
			playerGearItemSlotControl.Name = "armorSuitSlot";
		}
		this.b(playerGearItemSlotControl);
		return playerGearItemSlotControl;
	}

	// Token: 0x0600C530 RID: 50480 RVA: 0x0044CA70 File Offset: 0x0044AC70
	private void b(cqy A_0)
	{
		this.aox(A_0);
	}

	// Token: 0x0600C531 RID: 50481 RVA: 0x0044CA80 File Offset: 0x0044AC80
	private void a(cqy A_0)
	{
		if (A_0.yg(this.j) && this.j.ye(A_0, A_0.x6()) && c69.a(A_0, this.j, A_0.x6(), true))
		{
			e4z.c();
		}
	}

	// Token: 0x0600C532 RID: 50482 RVA: 0x0044CAD4 File Offset: 0x0044ACD4
	protected override void lq(object A_0, b25 A_1)
	{
		base.lq(A_0, A_1);
		if (A_1.b() == eoo.d)
		{
			d4f.a();
		}
	}

	// Token: 0x0600C533 RID: 50483 RVA: 0x0044CAF4 File Offset: 0x0044ACF4
	private void b(object A_0, b25 A_1)
	{
		KeyboardState state = Keyboard.GetState();
		if (A_1.b() == eoo.b && (state.IsKeyDown(Keys.LeftControl) || state.IsKeyDown(Keys.RightControl)) && !d4f.b())
		{
			cqy cqy = A_0 as cqy;
			if (cqy.ah8() && cqy != null && cqy.x6() != null)
			{
				this.a(cqy);
			}
		}
	}

	// Token: 0x0600C534 RID: 50484 RVA: 0x0044CB6C File Offset: 0x0044AD6C
	private void a(object A_0, b25 A_1)
	{
		if (A_1.b() == eoo.b)
		{
			cqy cqy = A_0 as cqy;
			if (cqy.ah8() && cqy != null && cqy.x6() != null)
			{
				this.a(cqy);
			}
		}
	}

	// Token: 0x04004829 RID: 18473
	public new const string a = "CharacterGearSlot";

	// Token: 0x0400482A RID: 18474
	public new const string b = "CharacterQuickSlotName";

	// Token: 0x0400482B RID: 18475
	private new int c = 120;

	// Token: 0x0400482C RID: 18476
	private new Point d = new Point(70, 180);

	// Token: 0x0400482D RID: 18477
	private new int e = 75;

	// Token: 0x0400482E RID: 18478
	private new int f = 140;

	// Token: 0x0400482F RID: 18479
	private new int g = 305;

	// Token: 0x04004830 RID: 18480
	private Point h = new Point(42, 44);

	// Token: 0x04004831 RID: 18481
	private int i = 12;

	// Token: 0x04004832 RID: 18482
	private new b3w j;

	// Token: 0x04004833 RID: 18483
	private new efk k;

	// Token: 0x04004834 RID: 18484
	private new bg1 l;

	// Token: 0x04004835 RID: 18485
	public new List<b75> m;

	// Token: 0x04004836 RID: 18486
	public List<cqy> n;

	// Token: 0x04004837 RID: 18487
	public PlayerGearItemSlotControl<k7> o;

	// Token: 0x04004838 RID: 18488
	public PlayerGearItemSlotControl<cgd> p;

	// Token: 0x04004839 RID: 18489
	public PlayerGearItemSlotControl<c8d> q;

	// Token: 0x0400483A RID: 18490
	public PlayerGearItemSlotControl<cjh> r;

	// Token: 0x0400483B RID: 18491
	public PlayerGearItemSlotControl<a12> s;

	// Token: 0x0400483C RID: 18492
	public PlayerGearItemSlotControl<cd1> t;

	// Token: 0x0400483D RID: 18493
	public PlayerGearItemSlotControl<cd1> u;

	// Token: 0x0400483E RID: 18494
	private euz v;

	// Token: 0x0400483F RID: 18495
	private Func<coh> w;
}
