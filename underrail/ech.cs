using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001E3A RID: 7738
[eiz("S3")]
[DefaultMember("Item")]
[Serializable]
public class ech : xx, IEnumerable<csn>, ICloneable, dw3, ISerializable
{
	// Token: 0x0600AB81 RID: 43905 RVA: 0x003F6DBC File Offset: 0x003F4FBC
	protected ech(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (efk)A_0.GetValue("S3:C", typeof(efk));
			di7.ReadList<csn>("S3:S", ref this.b, A_0);
			if (ell.b() >= 5)
			{
				di7.ReadEvent<EventArgs>("S3:SA", ref this.d, A_0);
				di7.ReadEvent<c1>("S3:SVC", ref this.e, A_0);
				return;
			}
			this.e = (EventHandler<c1>)A_0.GetValue("S3:SVC", typeof(EventHandler<c1>));
			return;
		}
		else
		{
			if (base.GetType() == typeof(ech))
			{
				this.a = (efk)A_0.GetValue("_Character", typeof(efk));
				this.b = (List<csn>)A_0.GetValue("_Skills", typeof(List<csn>));
				this.e = (EventHandler<c1>)A_0.GetValue("SkillValueChanged", typeof(EventHandler<c1>));
				return;
			}
			this.a = (efk)A_0.GetValue("Skills+_Character", typeof(efk));
			this.b = (List<csn>)A_0.GetValue("Skills+_Skills", typeof(List<csn>));
			this.e = (EventHandler<c1>)A_0.GetValue("Skills+SkillValueChanged", typeof(EventHandler<c1>));
			return;
		}
	}

	// Token: 0x0600AB82 RID: 43906 RVA: 0x003F6F4C File Offset: 0x003F514C
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("S3:C", this.a);
		di7.WriteList<csn>("S3:S", this.b, info);
		di7.WriteEvent<EventArgs>("S3:SA", this.d, info);
		di7.WriteEvent<c1>("S3:SVC", this.e, info);
	}

	// Token: 0x0600AB83 RID: 43907 RVA: 0x003F6FA0 File Offset: 0x003F51A0
	public efk re()
	{
		return this.a;
	}

	// Token: 0x0600AB84 RID: 43908 RVA: 0x003F6FA8 File Offset: 0x003F51A8
	protected List<csn> d()
	{
		return this.b;
	}

	// Token: 0x0600AB85 RID: 43909 RVA: 0x003F6FB0 File Offset: 0x003F51B0
	public ech()
	{
	}

	// Token: 0x0600AB86 RID: 43910 RVA: 0x003F6FD0 File Offset: 0x003F51D0
	public ech(efk A_0) : this()
	{
		this.a = A_0;
	}

	// Token: 0x0600AB87 RID: 43911 RVA: 0x003F6FE0 File Offset: 0x003F51E0
	public csn b(string A_0)
	{
		return this.a(A_0);
	}

	// Token: 0x0600AB88 RID: 43912 RVA: 0x003F6FEC File Offset: 0x003F51EC
	public csn b(Type A_0)
	{
		return this.a(A_0);
	}

	// Token: 0x0600AB89 RID: 43913 RVA: 0x003F6FF8 File Offset: 0x003F51F8
	[CompilerGenerated]
	public void a(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.d;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.d, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600AB8A RID: 43914 RVA: 0x003F7030 File Offset: 0x003F5230
	[CompilerGenerated]
	public void b(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.d;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.d, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600AB8B RID: 43915 RVA: 0x003F7068 File Offset: 0x003F5268
	[CompilerGenerated]
	public void b(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.e;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.e, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600AB8C RID: 43916 RVA: 0x003F70A0 File Offset: 0x003F52A0
	[CompilerGenerated]
	public void a(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.e;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.e, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600AB8D RID: 43917 RVA: 0x003F70D8 File Offset: 0x003F52D8
	public csn a(string A_0)
	{
		if (A_0 == null)
		{
			return null;
		}
		ech.b b = new ech.b();
		if (this.c.ContainsKey(A_0))
		{
			return this.c[A_0];
		}
		b.a = A_0.ToLowerInvariant();
		csn csn = Enumerable.FirstOrDefault<csn>(Enumerable.Where<csn>(this.b, new Func<csn, bool>(b.a)));
		this.c[A_0] = csn;
		return csn;
	}

	// Token: 0x0600AB8E RID: 43918 RVA: 0x003F7148 File Offset: 0x003F5348
	public csn a(Type A_0)
	{
		ech.a a = new ech.a();
		a.a = A_0;
		if (this.c.ContainsKey(a.a.FullName))
		{
			return this.c[a.a.FullName];
		}
		csn csn = Enumerable.FirstOrDefault<csn>(Enumerable.Where<csn>(this.b, new Func<csn, bool>(a.a)));
		this.c[a.a.FullName] = csn;
		return csn;
	}

	// Token: 0x0600AB8F RID: 43919 RVA: 0x003F71CC File Offset: 0x003F53CC
	public T Get<T>() where T : csn
	{
		return this.a(typeof(T)) as T;
	}

	// Token: 0x0600AB90 RID: 43920 RVA: 0x003F71EC File Offset: 0x003F53EC
	public List<csn> a(SkillCategory A_0)
	{
		ech.c c = new ech.c();
		c.a = A_0;
		return Enumerable.ToList<csn>(Enumerable.Where<csn>(this.b, new Func<csn, bool>(c.a)));
	}

	// Token: 0x0600AB91 RID: 43921 RVA: 0x003F7224 File Offset: 0x003F5424
	public ech b()
	{
		return (ech)this.Clone();
	}

	// Token: 0x0600AB92 RID: 43922 RVA: 0x003F7234 File Offset: 0x003F5434
	public object Clone()
	{
		ech ech = new ech(this.re());
		foreach (csn csn in this)
		{
			Type type = csn.GetType();
			object[] array = new object[2];
			array[0] = csn.f();
			csn a_ = Activator.CreateInstance(type, array) as csn;
			ech.a(a_);
		}
		return ech;
	}

	// Token: 0x0600AB93 RID: 43923 RVA: 0x003F72B8 File Offset: 0x003F54B8
	public void a(ll A_0, IEnumerable<RequirementRestrictedElementContainer<d3e>> A_1)
	{
		Dictionary<csn, int> dictionary = ech.a(A_0.a());
		foreach (csn csn in this.b)
		{
			int? a_ = null;
			int value;
			if (dictionary.TryGetValue(csn, out value))
			{
				a_ = new int?(value);
			}
			csn.a(this.re(), a_);
			csn.a(dictionary);
		}
		if (A_0 != null && A_0.a() != null)
		{
			foreach (RequirementRestrictedElementContainer<d3e> a_2 in A_1)
			{
				A_0.a().a(a_2, A_0);
			}
		}
	}

	// Token: 0x0600AB94 RID: 43924 RVA: 0x003F73A8 File Offset: 0x003F55A8
	public static Dictionary<csn, int> a(efk A_0, bc7 A_1, a1u A_2 = null)
	{
		Dictionary<csn, int> dictionary = new Dictionary<csn, int>();
		if (A_0 != null)
		{
			foreach (csn csn in A_0.Skills.b)
			{
				SkillEnum key;
				if (Enum.TryParse<SkillEnum>(csn.Name.Replace(" ", ""), out key))
				{
					bool flag = false;
					int num = csn.f();
					bnw.a a;
					if (A_1 != null && A_1.a.TryGetValue(key, out a) && a.b != 0)
					{
						num = Math.Max(csn.f() + a.b / 2, a.c);
						flag = true;
					}
					int num2;
					if (A_2 != null && A_2 != null && A_2.b.TryGetValue(key, out num2) && num2 > 0)
					{
						num = Math.Max(aiy.v, num - num2);
						flag = true;
					}
					if (flag)
					{
						dictionary[csn] = num;
					}
				}
			}
		}
		return dictionary;
	}

	// Token: 0x0600AB95 RID: 43925 RVA: 0x003F74CC File Offset: 0x003F56CC
	public static Dictionary<csn, int> a(efk A_0)
	{
		bc7 a_ = Enumerable.FirstOrDefault<bc7>(A_0.StatusEffects.Get<bc7>());
		a1u a_2 = Enumerable.FirstOrDefault<a1u>(A_0.StatusEffects.Get<a1u>());
		return ech.a(A_0, a_, a_2);
	}

	// Token: 0x0600AB96 RID: 43926 RVA: 0x003F7504 File Offset: 0x003F5704
	internal void a(csn A_0)
	{
		czh.a(A_0, "skill");
		A_0.a(this);
		if (this.d != null)
		{
			this.d(A_0, new EventArgs());
		}
		this.b.Add(A_0);
	}

	// Token: 0x0600AB97 RID: 43927 RVA: 0x003F7540 File Offset: 0x003F5740
	public IEnumerator<csn> GetEnumerator()
	{
		return this.b.GetEnumerator();
	}

	// Token: 0x0600AB98 RID: 43928 RVA: 0x003F7554 File Offset: 0x003F5754
	IEnumerator IEnumerable.c()
	{
		return this.b.GetEnumerator();
	}

	// Token: 0x0600AB99 RID: 43929 RVA: 0x003F7568 File Offset: 0x003F5768
	void dw3.a(object A_0, object A_1, object A_2)
	{
		csn csn = A_0 as csn;
		if (csn != null && this.e != null)
		{
			this.e(csn, new c1(A_1, A_2));
		}
	}

	// Token: 0x04003FF2 RID: 16370
	private efk a;

	// Token: 0x04003FF3 RID: 16371
	internal List<csn> b = new List<csn>();

	// Token: 0x04003FF4 RID: 16372
	[NonSerialized]
	private Dictionary<string, csn> c = new Dictionary<string, csn>();

	// Token: 0x04003FF5 RID: 16373
	[CompilerGenerated]
	private EventHandler<EventArgs> d;

	// Token: 0x04003FF6 RID: 16374
	[CompilerGenerated]
	private EventHandler<c1> e;

	// Token: 0x02001E45 RID: 7749
	[CompilerGenerated]
	private sealed class b
	{
		// Token: 0x0600ABCD RID: 43981 RVA: 0x003F7A3C File Offset: 0x003F5C3C
		internal bool a(csn A_0)
		{
			return A_0.Name.ToLowerInvariant() == this.a;
		}

		// Token: 0x04003FFB RID: 16379
		public string a;
	}

	// Token: 0x02001E46 RID: 7750
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x0600ABCF RID: 43983 RVA: 0x003F7A5C File Offset: 0x003F5C5C
		internal bool a(csn A_0)
		{
			return A_0.GetType() == this.a;
		}

		// Token: 0x04003FFC RID: 16380
		public Type a;
	}

	// Token: 0x02001E47 RID: 7751
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x0600ABD1 RID: 43985 RVA: 0x003F7A78 File Offset: 0x003F5C78
		internal bool a(csn A_0)
		{
			return A_0.Category == this.a;
		}

		// Token: 0x04003FFD RID: 16381
		public SkillCategory a;
	}
}
