using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001E28 RID: 7720
[eiz("BA3")]
[DefaultMember("Item")]
[Serializable]
public sealed class bn2 : xx, ICloneable, IEnumerable<to>, dw3, ISerializable
{
	// Token: 0x0600AB07 RID: 43783 RVA: 0x003F56B0 File Offset: 0x003F38B0
	private bn2(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadList<to>("BA3:BA", ref this.a, A_0);
			this.b = (efk)A_0.GetValue("BA3:C", typeof(efk));
			if (ell.b() >= 5)
			{
				di7.ReadEvent<c1>("BA3:BAVC", ref this.c, A_0);
			}
			else
			{
				this.c = (EventHandler<c1>)A_0.GetValue("BA3:BAVC", typeof(EventHandler<c1>));
			}
		}
		else if (base.GetType() == typeof(bn2))
		{
			this.a = (List<to>)A_0.GetValue("_BaseAbilities", typeof(List<to>));
			this.b = (efk)A_0.GetValue("_Character", typeof(efk));
			this.c = (EventHandler<c1>)A_0.GetValue("BaseAbilityValueChanged", typeof(EventHandler<c1>));
		}
		else
		{
			this.a = (List<to>)A_0.GetValue("BaseAbilities+_BaseAbilities", typeof(List<to>));
			this.b = (efk)A_0.GetValue("BaseAbilities+_Character", typeof(efk));
			this.c = (EventHandler<c1>)A_0.GetValue("BaseAbilities+BaseAbilityValueChanged", typeof(EventHandler<c1>));
		}
		foreach (to to in this.a)
		{
			if (to is ac)
			{
				this.a.Remove(to);
				break;
			}
		}
	}

	// Token: 0x0600AB08 RID: 43784 RVA: 0x003F5890 File Offset: 0x003F3A90
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteList<to>("BA3:BA", this.a, info);
		info.AddValue("BA3:C", this.b);
		di7.WriteEvent<c1>("BA3:BAVC", this.c, info);
	}

	// Token: 0x0600AB09 RID: 43785 RVA: 0x003F58C8 File Offset: 0x003F3AC8
	public efk re()
	{
		return this.b;
	}

	// Token: 0x170002AA RID: 682
	// (get) Token: 0x0600AB0A RID: 43786 RVA: 0x003F58D0 File Offset: 0x003F3AD0
	public int Strength
	{
		get
		{
			return this.Get<d3m>().g();
		}
	}

	// Token: 0x170002AB RID: 683
	// (get) Token: 0x0600AB0B RID: 43787 RVA: 0x003F58E0 File Offset: 0x003F3AE0
	public int Dexterity
	{
		get
		{
			return this.Get<cwu>().g();
		}
	}

	// Token: 0x170002AC RID: 684
	// (get) Token: 0x0600AB0C RID: 43788 RVA: 0x003F58F0 File Offset: 0x003F3AF0
	public int Agility
	{
		get
		{
			return this.Get<dqg>().g();
		}
	}

	// Token: 0x170002AD RID: 685
	// (get) Token: 0x0600AB0D RID: 43789 RVA: 0x003F5900 File Offset: 0x003F3B00
	public int Perception
	{
		get
		{
			return this.Get<eav>().g();
		}
	}

	// Token: 0x170002AE RID: 686
	// (get) Token: 0x0600AB0E RID: 43790 RVA: 0x003F5910 File Offset: 0x003F3B10
	public int Constitution
	{
		get
		{
			return this.Get<axa>().g();
		}
	}

	// Token: 0x170002AF RID: 687
	// (get) Token: 0x0600AB0F RID: 43791 RVA: 0x003F5920 File Offset: 0x003F3B20
	public int Intelligence
	{
		get
		{
			return this.Get<av8>().g();
		}
	}

	// Token: 0x170002B0 RID: 688
	// (get) Token: 0x0600AB10 RID: 43792 RVA: 0x003F5930 File Offset: 0x003F3B30
	public int Will
	{
		get
		{
			return this.Get<axr>().g();
		}
	}

	// Token: 0x0600AB11 RID: 43793 RVA: 0x003F5940 File Offset: 0x003F3B40
	public List<to> b()
	{
		return this.a;
	}

	// Token: 0x0600AB12 RID: 43794 RVA: 0x003F5948 File Offset: 0x003F3B48
	public bn2()
	{
		this.a();
	}

	// Token: 0x0600AB13 RID: 43795 RVA: 0x003F5964 File Offset: 0x003F3B64
	public bn2(efk A_0) : this()
	{
		this.b = A_0;
	}

	// Token: 0x0600AB14 RID: 43796 RVA: 0x003F5974 File Offset: 0x003F3B74
	public to b(Type A_0)
	{
		return this.a(A_0);
	}

	// Token: 0x0600AB15 RID: 43797 RVA: 0x003F5980 File Offset: 0x003F3B80
	public to b(string A_0)
	{
		return this.a(A_0);
	}

	// Token: 0x0600AB16 RID: 43798 RVA: 0x003F598C File Offset: 0x003F3B8C
	[CompilerGenerated]
	public void b(EventHandler<c1> A_0)
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

	// Token: 0x0600AB17 RID: 43799 RVA: 0x003F59C4 File Offset: 0x003F3BC4
	[CompilerGenerated]
	public void a(EventHandler<c1> A_0)
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

	// Token: 0x0600AB18 RID: 43800 RVA: 0x003F59FC File Offset: 0x003F3BFC
	private void a()
	{
		this.a.Add(new d3m(this, aiy.s));
		this.a.Add(new cwu(this, aiy.s));
		this.a.Add(new dqg(this, aiy.s));
		this.a.Add(new axa(this, aiy.s));
		this.a.Add(new eav(this, aiy.s));
		this.a.Add(new axr(this, aiy.s));
		this.a.Add(new av8(this, aiy.s));
	}

	// Token: 0x0600AB19 RID: 43801 RVA: 0x003F5AA4 File Offset: 0x003F3CA4
	public to a(Type A_0)
	{
		bn2.a a = new bn2.a();
		a.a = A_0;
		czh.a(a.a, "baseAbilityType");
		return Enumerable.FirstOrDefault<to>(Enumerable.Where<to>(this.a, new Func<to, bool>(a.a)));
	}

	// Token: 0x0600AB1A RID: 43802 RVA: 0x003F5AEC File Offset: 0x003F3CEC
	public T Get<T>() where T : to
	{
		return Enumerable.FirstOrDefault<T>(Enumerable.OfType<T>(this.a));
	}

	// Token: 0x0600AB1B RID: 43803 RVA: 0x003F5B00 File Offset: 0x003F3D00
	public to a(string A_0)
	{
		bn2.b b = new bn2.b();
		czh.a(A_0, "name");
		b.a = A_0.ToLowerInvariant();
		return Enumerable.FirstOrDefault<to>(Enumerable.Where<to>(this.a, new Func<to, bool>(b.a)));
	}

	// Token: 0x0600AB1C RID: 43804 RVA: 0x003F5B48 File Offset: 0x003F3D48
	public void a(ll A_0, IEnumerable<RequirementRestrictedElementContainer<d3e>> A_1)
	{
		foreach (to to in this.a)
		{
			to.c();
		}
		if (A_0 != null && A_0.a() != null)
		{
			foreach (RequirementRestrictedElementContainer<d3e> a_ in A_1)
			{
				A_0.a().a(a_, A_0);
			}
		}
		foreach (to to2 in this.a)
		{
			to2.b();
		}
	}

	// Token: 0x0600AB1D RID: 43805 RVA: 0x003F5C3C File Offset: 0x003F3E3C
	public bn2 c()
	{
		return (bn2)this.Clone();
	}

	// Token: 0x0600AB1E RID: 43806 RVA: 0x003F5C4C File Offset: 0x003F3E4C
	public object Clone()
	{
		bn2 bn = new bn2(this.re());
		foreach (to to in this)
		{
			bn.b(to.Name).a(to.f());
		}
		return bn;
	}

	// Token: 0x0600AB1F RID: 43807 RVA: 0x003F5CBC File Offset: 0x003F3EBC
	public IEnumerator<to> GetEnumerator()
	{
		return this.a.GetEnumerator();
	}

	// Token: 0x0600AB20 RID: 43808 RVA: 0x003F5CD0 File Offset: 0x003F3ED0
	IEnumerator IEnumerable.d()
	{
		return this.a.GetEnumerator();
	}

	// Token: 0x0600AB21 RID: 43809 RVA: 0x003F5CE4 File Offset: 0x003F3EE4
	void dw3.a(object A_0, object A_1, object A_2)
	{
		to to = A_0 as to;
		if (to != null && this.c != null)
		{
			this.c(to, new c1(A_1, A_2));
		}
	}

	// Token: 0x04003FE0 RID: 16352
	private List<to> a = new List<to>();

	// Token: 0x04003FE1 RID: 16353
	private efk b;

	// Token: 0x04003FE2 RID: 16354
	[CompilerGenerated]
	private EventHandler<c1> c;

	// Token: 0x02001E29 RID: 7721
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x0600AB23 RID: 43811 RVA: 0x003F5D24 File Offset: 0x003F3F24
		internal bool a(to A_0)
		{
			return A_0.GetType() == this.a;
		}

		// Token: 0x04003FE3 RID: 16355
		public Type a;
	}

	// Token: 0x02001E2A RID: 7722
	[CompilerGenerated]
	private sealed class b
	{
		// Token: 0x0600AB25 RID: 43813 RVA: 0x003F5D40 File Offset: 0x003F3F40
		internal bool a(to A_0)
		{
			return A_0.Name.ToLowerInvariant() == this.a;
		}

		// Token: 0x04003FE4 RID: 16356
		public string a;
	}
}
