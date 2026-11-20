using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001E4E RID: 7758
[eiz("CGS")]
[Serializable]
public sealed class acd : ISerializable
{
	// Token: 0x0600ABF6 RID: 44022 RVA: 0x003F7D8C File Offset: 0x003F5F8C
	private void a(ItemSlot<acz>[] A_0)
	{
		this.f = new ItemSlot<coh>[aiy.ay];
		for (int i = 0; i < aiy.ay; i++)
		{
			ItemSlot<acz> itemSlot = A_0[i];
			ItemSlot<coh> itemSlot2 = new ItemSlot<coh>();
			itemSlot.TransferEvent<coh>(itemSlot2);
			itemSlot2.a = itemSlot.a;
			itemSlot2.b = itemSlot.b;
			this.f[i] = itemSlot2;
		}
	}

	// Token: 0x0600ABF7 RID: 44023 RVA: 0x003F7DF8 File Offset: 0x003F5FF8
	private acd(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (ItemSlot<k7>)A_0.GetValue("CGS:H", typeof(ItemSlot<k7>));
			this.b = (ItemSlot<c8d>)A_0.GetValue("CGS:A", typeof(ItemSlot<c8d>));
			this.c = (ItemSlot<cjh>)A_0.GetValue("CGS:B", typeof(ItemSlot<cjh>));
			this.d = (ItemSlot<a12>)A_0.GetValue("CGS:B1", typeof(ItemSlot<a12>));
			this.e = (ItemSlot<cgd>)A_0.GetValue("CGS:SE", typeof(ItemSlot<cgd>));
			if (ell.a() >= 608)
			{
				di7.ReadArray<ItemSlot<coh>>("CGS:QSI", ref this.f, A_0);
			}
			else
			{
				ItemSlot<acz>[] a_ = new ItemSlot<acz>[aiy.ay];
				di7.ReadArray<ItemSlot<acz>>("CGS:QSI", ref a_, A_0);
				this.a(a_);
			}
			di7.ReadDictionary<WeaponKey, ItemSlot<cd1>>("CGS:W", ref this.g, A_0);
			this.h = A_0.GetInt32("CGS:AQS");
			if (ell.b() >= 5)
			{
				di7.ReadEvent<by0>("CGS:IE", ref this.i, A_0);
				di7.ReadEvent<by0>("CGS:IU", ref this.j, A_0);
				return;
			}
			this.i = (EventHandler<by0>)A_0.GetValue("CGS:IE", typeof(EventHandler<by0>));
			this.j = (EventHandler<by0>)A_0.GetValue("CGS:IU", typeof(EventHandler<by0>));
			return;
		}
		else
		{
			if (base.GetType() == typeof(acd))
			{
				this.a = (ItemSlot<k7>)A_0.GetValue("_Helmet", typeof(ItemSlot<k7>));
				this.b = (ItemSlot<c8d>)A_0.GetValue("_Armor", typeof(ItemSlot<c8d>));
				this.c = (ItemSlot<cjh>)A_0.GetValue("_Belt", typeof(ItemSlot<cjh>));
				this.d = (ItemSlot<a12>)A_0.GetValue("_Boots", typeof(ItemSlot<a12>));
				this.e = (ItemSlot<cgd>)A_0.GetValue("_ShieldEmitter", typeof(ItemSlot<cgd>));
				this.a((ItemSlot<acz>[])A_0.GetValue("_QuickSlotItems", typeof(ItemSlot<acz>[])));
				this.g = (Dictionary<WeaponKey, ItemSlot<cd1>>)A_0.GetValue("_Weapons", typeof(Dictionary<WeaponKey, ItemSlot<cd1>>));
				this.h = A_0.GetInt32("_AvailableQuickSlots");
				this.i = (EventHandler<by0>)A_0.GetValue("ItemEquipped", typeof(EventHandler<by0>));
				this.j = (EventHandler<by0>)A_0.GetValue("ItemUnequipped", typeof(EventHandler<by0>));
				return;
			}
			this.a = (ItemSlot<k7>)A_0.GetValue("CharacterGearSet+_Helmet", typeof(ItemSlot<k7>));
			this.b = (ItemSlot<c8d>)A_0.GetValue("CharacterGearSet+_Armor", typeof(ItemSlot<c8d>));
			this.c = (ItemSlot<cjh>)A_0.GetValue("CharacterGearSet+_Belt", typeof(ItemSlot<cjh>));
			this.d = (ItemSlot<a12>)A_0.GetValue("CharacterGearSet+_Boots", typeof(ItemSlot<a12>));
			this.e = (ItemSlot<cgd>)A_0.GetValue("CharacterGearSet+_ShieldEmitter", typeof(ItemSlot<cgd>));
			this.a((ItemSlot<acz>[])A_0.GetValue("CharacterGearSet+_QuickSlotItems", typeof(ItemSlot<acz>[])));
			this.g = (Dictionary<WeaponKey, ItemSlot<cd1>>)A_0.GetValue("CharacterGearSet+_Weapons", typeof(Dictionary<WeaponKey, ItemSlot<cd1>>));
			this.h = A_0.GetInt32("CharacterGearSet+_AvailableQuickSlots");
			this.i = (EventHandler<by0>)A_0.GetValue("CharacterGearSet+ItemEquipped", typeof(EventHandler<by0>));
			this.j = (EventHandler<by0>)A_0.GetValue("CharacterGearSet+ItemUnequipped", typeof(EventHandler<by0>));
			return;
		}
	}

	// Token: 0x0600ABF8 RID: 44024 RVA: 0x003F8240 File Offset: 0x003F6440
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("CGS:H", this.a);
		info.AddValue("CGS:A", this.b);
		info.AddValue("CGS:B", this.c);
		info.AddValue("CGS:B1", this.d);
		info.AddValue("CGS:SE", this.e);
		di7.WriteArray<ItemSlot<coh>>("CGS:QSI", this.f, info);
		di7.WriteDictionary<WeaponKey, ItemSlot<cd1>>("CGS:W", this.g, info);
		info.AddValue("CGS:AQS", this.h);
		di7.WriteEvent<by0>("CGS:IE", this.i, info);
		di7.WriteEvent<by0>("CGS:IU", this.j, info);
	}

	// Token: 0x0600ABF9 RID: 44025 RVA: 0x003F82F8 File Offset: 0x003F64F8
	public Dictionary<WeaponKey, ItemSlot<cd1>> j()
	{
		return this.g;
	}

	// Token: 0x0600ABFA RID: 44026 RVA: 0x003F8300 File Offset: 0x003F6500
	public ItemSlot<k7> g()
	{
		return this.a;
	}

	// Token: 0x0600ABFB RID: 44027 RVA: 0x003F8308 File Offset: 0x003F6508
	public ItemSlot<c8d> l()
	{
		return this.b;
	}

	// Token: 0x0600ABFC RID: 44028 RVA: 0x003F8310 File Offset: 0x003F6510
	public ItemSlot<cjh> e()
	{
		return this.c;
	}

	// Token: 0x0600ABFD RID: 44029 RVA: 0x003F8318 File Offset: 0x003F6518
	public ItemSlot<a12> f()
	{
		return this.d;
	}

	// Token: 0x0600ABFE RID: 44030 RVA: 0x003F8320 File Offset: 0x003F6520
	public ItemSlot<cgd> h()
	{
		return this.e;
	}

	// Token: 0x0600ABFF RID: 44031 RVA: 0x003F8328 File Offset: 0x003F6528
	public ItemSlot<coh>[] d()
	{
		return this.f;
	}

	// Token: 0x0600AC00 RID: 44032 RVA: 0x003F8330 File Offset: 0x003F6530
	public int m()
	{
		return this.h;
	}

	// Token: 0x0600AC01 RID: 44033 RVA: 0x003F833C File Offset: 0x003F653C
	[CompilerGenerated]
	public void d(EventHandler<by0> A_0)
	{
		EventHandler<by0> eventHandler = this.i;
		EventHandler<by0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<by0> value = (EventHandler<by0>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<by0>>(ref this.i, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600AC02 RID: 44034 RVA: 0x003F8374 File Offset: 0x003F6574
	[CompilerGenerated]
	public void c(EventHandler<by0> A_0)
	{
		EventHandler<by0> eventHandler = this.i;
		EventHandler<by0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<by0> value = (EventHandler<by0>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<by0>>(ref this.i, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600AC03 RID: 44035 RVA: 0x003F83AC File Offset: 0x003F65AC
	[CompilerGenerated]
	public void b(EventHandler<by0> A_0)
	{
		EventHandler<by0> eventHandler = this.j;
		EventHandler<by0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<by0> value = (EventHandler<by0>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<by0>>(ref this.j, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600AC04 RID: 44036 RVA: 0x003F83E4 File Offset: 0x003F65E4
	[CompilerGenerated]
	public void a(EventHandler<by0> A_0)
	{
		EventHandler<by0> eventHandler = this.j;
		EventHandler<by0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<by0> value = (EventHandler<by0>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<by0>>(ref this.j, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600AC05 RID: 44037 RVA: 0x003F841C File Offset: 0x003F661C
	public acd()
	{
		this.c();
		this.b();
		this.a();
	}

	// Token: 0x0600AC06 RID: 44038 RVA: 0x003F8478 File Offset: 0x003F6678
	public bool a(IItemInstance<bk3> A_0)
	{
		acd.b b = new acd.b();
		b.a = A_0;
		return Enumerable.Any<ItemSlot<coh>>(this.f, new Func<ItemSlot<coh>, bool>(b.a));
	}

	// Token: 0x0600AC07 RID: 44039 RVA: 0x003F84AC File Offset: 0x003F66AC
	public List<coh> a(int A_0)
	{
		List<coh> list = new List<coh>();
		if (A_0 != this.h)
		{
			this.h = A_0;
			for (int i = 0; i < aiy.ay; i++)
			{
				if (i < this.h)
				{
					this.f[i].Enabled = true;
				}
				else
				{
					this.f[i].Enabled = false;
					if (this.f[i].Item != null)
					{
						list.Add(this.f[i].Item);
						this.f[i].Item = null;
					}
				}
			}
		}
		return list;
	}

	// Token: 0x0600AC08 RID: 44040 RVA: 0x003F855C File Offset: 0x003F675C
	public bool c(coh A_0)
	{
		if (this.b.Item == A_0)
		{
			this.b.Item = null;
			return true;
		}
		if (this.a.Item == A_0)
		{
			this.a.Item = null;
			return true;
		}
		if (this.c.Item == A_0)
		{
			this.c.Item = null;
			return true;
		}
		if (this.d.Item == A_0)
		{
			this.d.Item = null;
			return true;
		}
		if (this.e.Item == A_0)
		{
			this.e.Item = null;
			return true;
		}
		if (this.g[WeaponKey.Primary].Item == A_0)
		{
			this.g[WeaponKey.Primary].Item = null;
			return true;
		}
		if (this.g[WeaponKey.Secondary].Item == A_0)
		{
			this.g[WeaponKey.Secondary].Item = null;
			return true;
		}
		foreach (ItemSlot<coh> itemSlot in this.f)
		{
			if (itemSlot.Item == A_0)
			{
				itemSlot.Item = null;
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600AC09 RID: 44041 RVA: 0x003F8690 File Offset: 0x003F6890
	private static coh a(c1e A_0, Guid A_1)
	{
		if (A_0.Value != null && A_0.Value.Id == A_1)
		{
			coh result = A_0.Value;
			A_0.Value = null;
			return result;
		}
		return null;
	}

	// Token: 0x0600AC0A RID: 44042 RVA: 0x003F86D0 File Offset: 0x003F68D0
	public coh a(Guid A_0)
	{
		coh coh = acd.a(this.b, A_0);
		if (coh != null)
		{
			return coh;
		}
		coh = acd.a(this.a, A_0);
		if (coh != null)
		{
			return coh;
		}
		coh = acd.a(this.c, A_0);
		if (coh != null)
		{
			return coh;
		}
		coh = acd.a(this.d, A_0);
		if (coh != null)
		{
			return coh;
		}
		coh = acd.a(this.e, A_0);
		if (coh != null)
		{
			return coh;
		}
		coh = acd.a(this.g[WeaponKey.Primary], A_0);
		if (coh != null)
		{
			return coh;
		}
		coh = acd.a(this.g[WeaponKey.Secondary], A_0);
		if (coh != null)
		{
			return coh;
		}
		ItemSlot<coh>[] array = this.f;
		for (int i = 0; i < array.Length; i++)
		{
			coh = acd.a(array[i], A_0);
			if (coh != null)
			{
				return coh;
			}
		}
		return coh;
	}

	// Token: 0x0600AC0B RID: 44043 RVA: 0x003F87B0 File Offset: 0x003F69B0
	public coh b(Guid A_0)
	{
		acd.a a = new acd.a();
		a.a = A_0;
		return Enumerable.FirstOrDefault<coh>(Enumerable.Where<coh>(this.i(), new Func<coh, bool>(a.a)));
	}

	// Token: 0x0600AC0C RID: 44044 RVA: 0x003F87E8 File Offset: 0x003F69E8
	public coh b(string A_0)
	{
		return Enumerable.FirstOrDefault<coh>(this.a(A_0));
	}

	// Token: 0x0600AC0D RID: 44045 RVA: 0x003F87F8 File Offset: 0x003F69F8
	public IEnumerable<coh> a(string A_0)
	{
		acd.c c = new acd.c();
		c.a = A_0;
		return Enumerable.Where<coh>(this.i(), new Func<coh, bool>(c.a));
	}

	// Token: 0x0600AC0E RID: 44046 RVA: 0x003F882C File Offset: 0x003F6A2C
	public coh a(string A_0, int A_1)
	{
		coh coh = this.b(A_0);
		if (coh == null)
		{
			return null;
		}
		if (A_1 <= 0 || A_1 >= coh.Stacks)
		{
			this.c(coh);
			return coh;
		}
		coh.Stacks -= A_1;
		coh coh2 = coh.fy();
		coh2.Stacks = A_1;
		return coh2;
	}

	// Token: 0x0600AC0F RID: 44047 RVA: 0x003F8884 File Offset: 0x003F6A84
	public List<coh> i()
	{
		List<coh> list = new List<coh>();
		if (this.b.Item != null)
		{
			list.Add(this.b.Item);
		}
		if (this.a.Item != null)
		{
			list.Add(this.a.Item);
		}
		if (this.c.Item != null)
		{
			list.Add(this.c.Item);
		}
		if (this.d.Item != null)
		{
			list.Add(this.d.Item);
		}
		if (this.e.Item != null)
		{
			list.Add(this.e.Item);
		}
		if (this.g[WeaponKey.Primary].Item != null)
		{
			list.Add(this.g[WeaponKey.Primary].Item);
		}
		if (this.g[WeaponKey.Secondary].Item != null)
		{
			list.Add(this.g[WeaponKey.Secondary].Item);
		}
		foreach (ItemSlot<coh> itemSlot in this.f)
		{
			if (itemSlot.Item != null)
			{
				list.Add(itemSlot.Item);
			}
		}
		return list;
	}

	// Token: 0x0600AC10 RID: 44048 RVA: 0x003F89D0 File Offset: 0x003F6BD0
	public List<coh> k()
	{
		List<coh> list = new List<coh>();
		if (this.b.Item != null)
		{
			list.Add(this.b.Item);
		}
		if (this.a.Item != null)
		{
			list.Add(this.a.Item);
		}
		if (this.c.Item != null)
		{
			list.Add(this.c.Item);
		}
		if (this.d.Item != null)
		{
			list.Add(this.d.Item);
		}
		if (this.e.Item != null)
		{
			list.Add(this.e.Item);
		}
		return list;
	}

	// Token: 0x0600AC11 RID: 44049 RVA: 0x003F8A8C File Offset: 0x003F6C8C
	public Dictionary<string, coh> a(bool A_0)
	{
		Dictionary<string, coh> dictionary = new Dictionary<string, coh>();
		dictionary["Armor"] = this.b.Item;
		dictionary["Helmet"] = this.a.Item;
		dictionary["Belt"] = this.c.Item;
		dictionary["Boots"] = this.d.Item;
		dictionary["ShieldEmitter"] = this.e.Item;
		dictionary["Weapon1"] = this.g[WeaponKey.Primary].Item;
		dictionary["Weapon2"] = this.g[WeaponKey.Secondary].Item;
		for (int i = 0; i < this.f.Length; i++)
		{
			dictionary["Quick" + i.ToString()] = this.f[i].Item;
		}
		if (A_0)
		{
			for (int j = 0; j < this.f.Length; j++)
			{
				this.f[j].a(null, true);
			}
			this.b.a(null, true);
			this.a.a(null, true);
			this.c.a(null, true);
			this.d.a(null, true);
			this.e.a(null, true);
			this.g[WeaponKey.Primary].a(null, true);
			this.g[WeaponKey.Secondary].a(null, true);
		}
		return dictionary;
	}

	// Token: 0x0600AC12 RID: 44050 RVA: 0x003F8C24 File Offset: 0x003F6E24
	public void a(Dictionary<string, coh> A_0)
	{
		for (int i = 0; i < this.f.Length; i++)
		{
			this.f[i].a(A_0["Quick" + i.ToString()] as acz, true);
		}
		this.b.a(A_0["Armor"] as c8d, true);
		this.a.a(A_0["Helmet"] as k7, true);
		this.c.a(A_0["Belt"] as cjh, true);
		this.d.a(A_0["Boots"] as a12, true);
		this.e.a(A_0["ShieldEmitter"] as cgd, true);
		this.g[WeaponKey.Primary].a(A_0["Weapon1"] as cd1, true);
		this.g[WeaponKey.Secondary].a(A_0["Weapon2"] as cd1, true);
	}

	// Token: 0x0600AC13 RID: 44051 RVA: 0x003F8D50 File Offset: 0x003F6F50
	private void c()
	{
		this.g = new Dictionary<WeaponKey, ItemSlot<cd1>>();
		this.g.Add(WeaponKey.Primary, new ItemSlot<cd1>());
		this.g.Add(WeaponKey.Secondary, new ItemSlot<cd1>());
	}

	// Token: 0x0600AC14 RID: 44052 RVA: 0x003F8D80 File Offset: 0x003F6F80
	private void b()
	{
		this.f = new ItemSlot<coh>[aiy.ay];
		for (int i = 0; i < aiy.ay; i++)
		{
			this.f[i] = new ItemSlot<coh>();
		}
	}

	// Token: 0x0600AC15 RID: 44053 RVA: 0x003F8DC4 File Offset: 0x003F6FC4
	private void a()
	{
		this.a.pm(new EventHandler<c1>(this.a));
		this.b.pm(new EventHandler<c1>(this.a));
		this.c.pm(new EventHandler<c1>(this.a));
		this.d.pm(new EventHandler<c1>(this.a));
		this.e.pm(new EventHandler<c1>(this.a));
		this.g[WeaponKey.Primary].pm(new EventHandler<c1>(this.a));
		this.g[WeaponKey.Secondary].pm(new EventHandler<c1>(this.a));
		ItemSlot<coh>[] array = this.f;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].pm(new EventHandler<c1>(this.a));
		}
	}

	// Token: 0x0600AC16 RID: 44054 RVA: 0x003F8EB0 File Offset: 0x003F70B0
	private void b(coh A_0)
	{
		if (this.i != null)
		{
			this.i(this, new by0(A_0));
		}
	}

	// Token: 0x0600AC17 RID: 44055 RVA: 0x003F8ED0 File Offset: 0x003F70D0
	private void a(coh A_0)
	{
		if (this.j != null)
		{
			this.j(this, new by0(A_0));
		}
	}

	// Token: 0x0600AC18 RID: 44056 RVA: 0x003F8EF0 File Offset: 0x003F70F0
	[dcc("CGS:mESIC")]
	private void a(object A_0, c1 A_1)
	{
		coh coh = A_1.b() as coh;
		coh coh2 = A_1.a() as coh;
		if (coh != null)
		{
			this.a(coh);
		}
		if (coh2 != null)
		{
			this.b(coh2);
		}
	}

	// Token: 0x04003FFE RID: 16382
	private ItemSlot<k7> a = new ItemSlot<k7>();

	// Token: 0x04003FFF RID: 16383
	private ItemSlot<c8d> b = new ItemSlot<c8d>();

	// Token: 0x04004000 RID: 16384
	private ItemSlot<cjh> c = new ItemSlot<cjh>();

	// Token: 0x04004001 RID: 16385
	private ItemSlot<a12> d = new ItemSlot<a12>();

	// Token: 0x04004002 RID: 16386
	private ItemSlot<cgd> e = new ItemSlot<cgd>();

	// Token: 0x04004003 RID: 16387
	private ItemSlot<coh>[] f;

	// Token: 0x04004004 RID: 16388
	private Dictionary<WeaponKey, ItemSlot<cd1>> g;

	// Token: 0x04004005 RID: 16389
	private int h;

	// Token: 0x04004006 RID: 16390
	[CompilerGenerated]
	private EventHandler<by0> i;

	// Token: 0x04004007 RID: 16391
	[CompilerGenerated]
	private EventHandler<by0> j;

	// Token: 0x02001E4F RID: 7759
	[CompilerGenerated]
	private sealed class b
	{
		// Token: 0x0600AC1A RID: 44058 RVA: 0x003F8F38 File Offset: 0x003F7138
		internal bool a(ItemSlot<coh> A_0)
		{
			return A_0.Item == this.a;
		}

		// Token: 0x04004008 RID: 16392
		public IItemInstance<bk3> a;
	}

	// Token: 0x02001E50 RID: 7760
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x0600AC1C RID: 44060 RVA: 0x003F8F50 File Offset: 0x003F7150
		internal bool a(coh A_0)
		{
			return A_0.Id == this.a;
		}

		// Token: 0x04004009 RID: 16393
		public Guid a;
	}

	// Token: 0x02001E51 RID: 7761
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x0600AC1E RID: 44062 RVA: 0x003F8F6C File Offset: 0x003F716C
		internal bool a(coh A_0)
		{
			return A_0.Definition != null && A_0.Definition.a5() == this.a;
		}

		// Token: 0x0400400A RID: 16394
		public string a;
	}
}
