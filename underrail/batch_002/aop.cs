using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x02001DD7 RID: 7639
[eiz("A7")]
[Serializable]
public sealed class aop : ISerializable
{
	// Token: 0x0600A904 RID: 43268 RVA: 0x003EF4E8 File Offset: 0x003ED6E8
	private aop(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.b = (efk)A_0.GetValue("A7:C", typeof(efk));
			di7.ReadDictionary<aia, dph>("A7:AA", ref this.c, A_0);
			di7.ReadList<els>("A7:USE", ref this.d, A_0);
			this.e = A_0.GetDouble("A7:UC");
			return;
		}
		if (base.GetType() == typeof(aop))
		{
			this.b = (efk)A_0.GetValue("_Character", typeof(efk));
			this.c = (Dictionary<aia, dph>)A_0.GetValue("_ActiveAuras", typeof(Dictionary<aia, dph>));
			this.d = (List<els>)A_0.GetValue("_UnappliedStatusEffect", typeof(List<els>));
			this.e = A_0.GetDouble("_UpdateCache");
			return;
		}
		this.b = (efk)A_0.GetValue("Auras+_Character", typeof(efk));
		this.c = (Dictionary<aia, dph>)A_0.GetValue("Auras+_ActiveAuras", typeof(Dictionary<aia, dph>));
		this.d = (List<els>)A_0.GetValue("Auras+_UnappliedStatusEffect", typeof(List<els>));
		this.e = A_0.GetDouble("Auras+_UpdateCache");
	}

	// Token: 0x0600A905 RID: 43269 RVA: 0x003EF66C File Offset: 0x003ED86C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("A7:C", this.b);
		di7.WriteDictionary<aia, dph>("A7:AA", this.c, info);
		di7.WriteList<els>("A7:USE", this.d, info);
		info.AddValue("A7:UC", this.e);
	}

	// Token: 0x0600A906 RID: 43270 RVA: 0x003EF6C0 File Offset: 0x003ED8C0
	public Dictionary<aia, dph> c()
	{
		return this.c;
	}

	// Token: 0x0600A907 RID: 43271 RVA: 0x003EF6CC File Offset: 0x003ED8CC
	public aop(efk A_0)
	{
		czh.a(A_0, "character");
		this.b = A_0;
		this.b.StatusEffects.f(new EventHandler<dwu>(this.b));
		this.b.StatusEffects.c(new EventHandler<dwu>(this.c));
		this.b.StatusEffects.g(new EventHandler<dwu>(this.a));
	}

	// Token: 0x0600A908 RID: 43272 RVA: 0x003EF75C File Offset: 0x003ED95C
	public void a(double A_0)
	{
		if ((this.e += A_0) > 200.0)
		{
			foreach (KeyValuePair<aia, dph> keyValuePair in Enumerable.ToList<KeyValuePair<aia, dph>>(this.c))
			{
				if (keyValuePair.Key.Value is a8s && !keyValuePair.Key.Value.cu(keyValuePair.Value.InvocationSet))
				{
					this.b(keyValuePair.Key.Value as a8s);
					eu2.a(keyValuePair.Key.Value, keyValuePair.Value.InvocationSet);
				}
			}
			this.e -= 200.0;
		}
	}

	// Token: 0x0600A909 RID: 43273 RVA: 0x003EF854 File Offset: 0x003EDA54
	public void b()
	{
		foreach (KeyValuePair<aia, dph> keyValuePair in Enumerable.ToList<KeyValuePair<aia, dph>>(this.c))
		{
			if (keyValuePair.Key.Value is a8s && !keyValuePair.Key.Value.cu(keyValuePair.Value.InvocationSet))
			{
				this.b(keyValuePair.Key.Value as a8s);
				eu2.a(keyValuePair.Key.Value, keyValuePair.Value.InvocationSet);
			}
		}
	}

	// Token: 0x0600A90A RID: 43274 RVA: 0x003EF918 File Offset: 0x003EDB18
	public void a(a8s A_0, cnm A_1)
	{
		czh.a(A_0, "aura");
		czh.a(A_1, "invocationSet");
		if (this.c(A_0))
		{
			this.b(A_0);
		}
		List<Type> list = A_0.f(A_1);
		if (list != null && list.Count > 0)
		{
			foreach (a8s a8s in Enumerable.Select<aia, a8s>(this.c.Keys, new Func<aia, a8s>(aop.d.a.a)))
			{
				using (List<Type>.Enumerator enumerator2 = list.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current.IsAssignableFrom(a8s.GetType()))
						{
							this.b(a8s);
						}
					}
				}
			}
		}
		List<els> list2 = A_0.j8(A_1);
		if (list2 != null && list2.Count > 0)
		{
			foreach (els els in list2)
			{
				if (this.b.StatusEffects.a(els, false, false, false) == ea4.b && els.Duration <= 0)
				{
					this.d.Add(els);
				}
			}
		}
		this.c.Add(A_0.e(), new dph(A_1, list2));
	}

	// Token: 0x0600A90B RID: 43275 RVA: 0x003EFAD4 File Offset: 0x003EDCD4
	public bool IsActive<TAura>() where TAura : a8s
	{
		return Enumerable.Any<KeyValuePair<aia, dph>>(this.c, new Func<KeyValuePair<aia, dph>, bool>(aop.<>c__13<TAura>.a.a));
	}

	// Token: 0x0600A90C RID: 43276 RVA: 0x003EFB04 File Offset: 0x003EDD04
	public bool c(a8s A_0)
	{
		aop.b b = new aop.b();
		b.a = A_0;
		return Enumerable.Any<aia>(this.c.Keys, new Func<aia, bool>(b.a));
	}

	// Token: 0x0600A90D RID: 43277 RVA: 0x003EFB3C File Offset: 0x003EDD3C
	public void b(a8s A_0)
	{
		czh.a(A_0, "aura");
		KeyValuePair<aia, dph> keyValuePair = this.a(A_0);
		if (keyValuePair.Key != null && keyValuePair.Value != null)
		{
			this.c.Remove(keyValuePair.Key);
			if (keyValuePair.Value.StatusEffects != null && keyValuePair.Value.StatusEffects.Count > 0)
			{
				foreach (els els in keyValuePair.Value.StatusEffects)
				{
					if (!this.d.Remove(els))
					{
						bab bab = els as bab;
						if (bab == null || !bab.pv(A_0))
						{
							this.b.StatusEffects.d(els);
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A90E RID: 43278 RVA: 0x003EFC38 File Offset: 0x003EDE38
	private KeyValuePair<aia, dph> a(a8s A_0)
	{
		aop.c c = new aop.c();
		c.a = A_0;
		return Enumerable.FirstOrDefault<KeyValuePair<aia, dph>>(Enumerable.Where<KeyValuePair<aia, dph>>(this.c, new Func<KeyValuePair<aia, dph>, bool>(c.a)));
	}

	// Token: 0x0600A90F RID: 43279 RVA: 0x003EFC70 File Offset: 0x003EDE70
	private void a()
	{
		for (int i = this.d.Count - 1; i >= 0; i--)
		{
			if (this.b.StatusEffects.a(this.d[i], false, false, false) == ea4.a)
			{
				this.d.RemoveAt(i);
			}
		}
	}

	// Token: 0x0600A910 RID: 43280 RVA: 0x003EFCC8 File Offset: 0x003EDEC8
	private void a(els A_0)
	{
		aop.a a = new aop.a();
		a.a = A_0;
		if (a.a.Duration <= 0 && Enumerable.Any<dph>(this.c.Values, new Func<dph, bool>(a.a)))
		{
			this.d.Add(a.a);
		}
	}

	// Token: 0x0600A911 RID: 43281 RVA: 0x003EFD28 File Offset: 0x003EDF28
	[OnDeserialized]
	private void a(StreamingContext A_0)
	{
		if (this.c == null)
		{
			this.c = new Dictionary<aia, dph>();
		}
	}

	// Token: 0x0600A912 RID: 43282 RVA: 0x003EFD40 File Offset: 0x003EDF40
	[dcc("A7:mSER")]
	private void c(object A_0, dwu A_1)
	{
		this.a();
	}

	// Token: 0x0600A913 RID: 43283 RVA: 0x003EFD48 File Offset: 0x003EDF48
	[dcc("A7:mSEE")]
	private void b(object A_0, dwu A_1)
	{
		this.a();
	}

	// Token: 0x0600A914 RID: 43284 RVA: 0x003EFD50 File Offset: 0x003EDF50
	[dcc("A7:mSESR")]
	private void a(object A_0, dwu A_1)
	{
		this.a(A_1.b());
	}

	// Token: 0x04003F31 RID: 16177
	private const int a = 200;

	// Token: 0x04003F32 RID: 16178
	private efk b;

	// Token: 0x04003F33 RID: 16179
	private Dictionary<aia, dph> c = new Dictionary<aia, dph>();

	// Token: 0x04003F34 RID: 16180
	private List<els> d = new List<els>();

	// Token: 0x04003F35 RID: 16181
	private double e;

	// Token: 0x02001DD8 RID: 7640
	[CompilerGenerated]
	[Serializable]
	private sealed class d
	{
		// Token: 0x0600A917 RID: 43287 RVA: 0x003EFD74 File Offset: 0x003EDF74
		internal a8s a(aia A_0)
		{
			return A_0.Value as a8s;
		}

		// Token: 0x04003F36 RID: 16182
		public static readonly aop.d a = new aop.d();

		// Token: 0x04003F37 RID: 16183
		public static Func<aia, a8s> b;
	}

	// Token: 0x02001DDA RID: 7642
	[CompilerGenerated]
	private sealed class b
	{
		// Token: 0x0600A91C RID: 43292 RVA: 0x003EFDB8 File Offset: 0x003EDFB8
		internal bool a(aia A_0)
		{
			return A_0.Value == this.a;
		}

		// Token: 0x04003F3A RID: 16186
		public a8s a;
	}

	// Token: 0x02001DDB RID: 7643
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x0600A91E RID: 43294 RVA: 0x003EFDD0 File Offset: 0x003EDFD0
		internal bool a(KeyValuePair<aia, dph> A_0)
		{
			return A_0.Key.Value == this.a;
		}

		// Token: 0x04003F3B RID: 16187
		public a8s a;
	}

	// Token: 0x02001DDC RID: 7644
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x0600A920 RID: 43296 RVA: 0x003EFDF0 File Offset: 0x003EDFF0
		internal bool a(dph A_0)
		{
			return A_0.StatusEffects.Contains(this.a);
		}

		// Token: 0x04003F3C RID: 16188
		public els a;
	}
}
