using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;
using Ouroboros.Playfield.References;

// Token: 0x020012E2 RID: 4834
[eiz("DX")]
[Serializable]
public sealed class bja : Aspect<c5x>, ISerializable, c98, bp1
{
	// Token: 0x06006B19 RID: 27417 RVA: 0x002D0A80 File Offset: 0x002CEC80
	private bja(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("DX:RG");
		this.b = A_0.GetInt32("DX:WC");
		this.c = A_0.GetInt32("DX:PWI");
		this.d = A_0.GetInt32("DX:CSI");
		this.e = A_0.GetInt32("DX:QS");
		this.f = A_0.GetDouble("DX:PWC");
		this.g = A_0.GetDouble("DX:CSC");
		this.h = (A_0.GetValue("DX:R", typeof(Queue<asf>)) as Queue<asf>);
		di7.ReadList<EntityAspectReference<bm6, bm6>>("DX:F", ref this.i, A_0);
		di7.ReadDictionary<Guid, List<EntityAspectReference<bm6, bm6>>>("DX:A", ref this.j, A_0);
		if (ell.a() >= 246)
		{
			di7.ReadList<cze>("DX:J", ref this.k, A_0);
			return;
		}
		this.k = new List<cze>();
	}

	// Token: 0x06006B1A RID: 27418 RVA: 0x002D0BC4 File Offset: 0x002CEDC4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DX:RG", this.a);
		info.AddValue("DX:WC", this.b);
		info.AddValue("DX:PWI", this.c);
		info.AddValue("DX:CSI", this.d);
		info.AddValue("DX:QS", this.e);
		info.AddValue("DX:PWC", this.f);
		info.AddValue("DX:CSC", this.g);
		info.AddValue("DX:R", this.h);
		di7.WriteList<EntityAspectReference<bm6, bm6>>("DX:F", this.i, info);
		di7.WriteDictionary<Guid, List<EntityAspectReference<bm6, bm6>>>("DX:A", this.j, info);
		di7.WriteList<cze>("DX:J", this.k, info);
	}

	// Token: 0x06006B1B RID: 27419 RVA: 0x002D0C94 File Offset: 0x002CEE94
	public string i()
	{
		return this.a;
	}

	// Token: 0x06006B1C RID: 27420 RVA: 0x002D0C9C File Offset: 0x002CEE9C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006B1D RID: 27421 RVA: 0x002D0CA8 File Offset: 0x002CEEA8
	public int e()
	{
		return this.b;
	}

	// Token: 0x06006B1E RID: 27422 RVA: 0x002D0CB0 File Offset: 0x002CEEB0
	public void c(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006B1F RID: 27423 RVA: 0x002D0CBC File Offset: 0x002CEEBC
	public int g()
	{
		return this.c;
	}

	// Token: 0x06006B20 RID: 27424 RVA: 0x002D0CC4 File Offset: 0x002CEEC4
	public void e(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006B21 RID: 27425 RVA: 0x002D0CD0 File Offset: 0x002CEED0
	public int h()
	{
		return this.d;
	}

	// Token: 0x06006B22 RID: 27426 RVA: 0x002D0CD8 File Offset: 0x002CEED8
	public void b(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006B23 RID: 27427 RVA: 0x002D0CE4 File Offset: 0x002CEEE4
	public int f()
	{
		return this.e;
	}

	// Token: 0x06006B24 RID: 27428 RVA: 0x002D0CEC File Offset: 0x002CEEEC
	public void d(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006B25 RID: 27429 RVA: 0x002D0CF8 File Offset: 0x002CEEF8
	public List<cze> k()
	{
		return this.k;
	}

	// Token: 0x06006B26 RID: 27430 RVA: 0x002D0D00 File Offset: 0x002CEF00
	public void a(List<cze> A_0)
	{
		this.k = A_0;
	}

	// Token: 0x06006B27 RID: 27431 RVA: 0x002D0D0C File Offset: 0x002CEF0C
	public bja(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006B28 RID: 27432 RVA: 0x002D0D6C File Offset: 0x002CEF6C
	public void mx()
	{
		this.b();
		this.d();
	}

	// Token: 0x06006B29 RID: 27433 RVA: 0x002D0D7C File Offset: 0x002CEF7C
	public void my()
	{
	}

	// Token: 0x06006B2A RID: 27434 RVA: 0x002D0D84 File Offset: 0x002CEF84
	public void r7(eds A_0)
	{
		if (this.c > 0 && (this.f -= A_0.b.TotalMilliseconds) <= 0.0)
		{
			this.f += (double)this.c;
			this.b();
		}
		if (this.d > 0 && (this.g -= A_0.b.TotalMilliseconds) <= 0.0)
		{
			this.g += (double)this.d;
			this.d();
		}
		this.a();
	}

	// Token: 0x06006B2B RID: 27435 RVA: 0x002D0E38 File Offset: 0x002CF038
	public void d(asf A_0)
	{
		if (!this.a(A_0))
		{
			this.c(A_0);
			this.h.Enqueue(A_0);
		}
		if (this.k.Count > 0)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary["SecurityDispatcherRequest"] = A_0;
			foreach (cze cze in this.k)
			{
				cze.ym(base.a8(), null, dictionary);
			}
		}
	}

	// Token: 0x06006B2C RID: 27436 RVA: 0x002D0EDC File Offset: 0x002CF0DC
	public List<b0b> j()
	{
		d60 d = base.a8().a();
		if (d != null)
		{
			return d.ab4(new string[]
			{
				this.a
			});
		}
		return new List<b0b>();
	}

	// Token: 0x06006B2D RID: 27437 RVA: 0x002D0F18 File Offset: 0x002CF118
	private bool c(asf A_0)
	{
		bool result = false;
		if (this.h.Count > 0)
		{
			Queue<asf> queue = new Queue<asf>();
			while (this.h.Count > 0)
			{
				asf asf = this.h.Dequeue();
				if (asf != null && asf.b != A_0.b)
				{
					queue.Enqueue(asf);
					result = true;
				}
			}
			this.h = queue;
		}
		return result;
	}

	// Token: 0x06006B2E RID: 27438 RVA: 0x002D0F8C File Offset: 0x002CF18C
	private void d()
	{
		List<Guid> list = new List<Guid>();
		foreach (KeyValuePair<Guid, List<EntityAspectReference<bm6, bm6>>> keyValuePair in this.j)
		{
			for (int i = keyValuePair.Value.Count - 1; i >= 0; i--)
			{
				EntityAspectReference<bm6, bm6> entityAspectReference = keyValuePair.Value[i];
				if (entityAspectReference.ao() == null)
				{
					keyValuePair.Value.RemoveAt(i);
				}
				else if (entityAspectReference.ao().y6().GetClassPropertyValue<string>(ddq.ai) == null)
				{
					keyValuePair.Value.RemoveAt(i);
					this.i.Add(entityAspectReference);
				}
			}
			if (keyValuePair.Value.Count == 0)
			{
				list.Add(keyValuePair.Key);
			}
		}
		foreach (Guid key in list)
		{
			this.j.Remove(key);
		}
	}

	// Token: 0x06006B2F RID: 27439 RVA: 0x002D10D0 File Offset: 0x002CF2D0
	private void b()
	{
		d60 d = base.a8().a();
		if (d != null && !string.IsNullOrEmpty(this.a))
		{
			List<b0b> list = d.ab4(new string[]
			{
				this.a
			});
			HashSet<bm6> hashSet = new HashSet<bm6>();
			foreach (b0b b0b in list)
			{
				c5x c5x = b0b as c5x;
				if (c5x != null && c5x.t.b != null)
				{
					hashSet.Add(c5x.t.b);
				}
			}
			for (int i = this.i.Count - 1; i >= 0; i--)
			{
				EntityAspectReference<bm6, bm6> entityAspectReference = this.i[i];
				if (entityAspectReference.ao() == null || !hashSet.Contains(entityAspectReference.ao()))
				{
					this.i.RemoveAt(i);
				}
				else
				{
					hashSet.Remove(entityAspectReference.ao());
				}
			}
			List<Guid> list2 = new List<Guid>();
			foreach (KeyValuePair<Guid, List<EntityAspectReference<bm6, bm6>>> keyValuePair in this.j)
			{
				for (int j = keyValuePair.Value.Count - 1; j >= 0; j--)
				{
					EntityAspectReference<bm6, bm6> entityAspectReference2 = keyValuePair.Value[j];
					if (entityAspectReference2.ao() == null || !hashSet.Contains(entityAspectReference2.ao()))
					{
						keyValuePair.Value.RemoveAt(j);
					}
					else
					{
						hashSet.Remove(entityAspectReference2.ao());
					}
				}
				if (keyValuePair.Value.Count == 0)
				{
					list2.Add(keyValuePair.Key);
				}
			}
			foreach (Guid key in list2)
			{
				this.j.Remove(key);
			}
			foreach (bm6 a_ in hashSet)
			{
				this.i.Add(new EntityAspectReference<bm6, bm6>(a_));
			}
		}
	}

	// Token: 0x06006B30 RID: 27440 RVA: 0x002D136C File Offset: 0x002CF56C
	private void a()
	{
		if (this.h.Count > 0 && this.i.Count > 0)
		{
			asf asf = this.h.Dequeue();
			if (!this.a(asf) && !this.b(asf))
			{
				this.h.Enqueue(asf);
			}
		}
	}

	// Token: 0x06006B31 RID: 27441 RVA: 0x002D13CC File Offset: 0x002CF5CC
	private bool b(asf A_0)
	{
		if (this.i == null)
		{
			return false;
		}
		List<EntityAspectReference<bm6, bm6>> list = this.a(this.b);
		foreach (EntityAspectReference<bm6, bm6> entityAspectReference in list)
		{
			if (entityAspectReference.ao() != null)
			{
				this.a(entityAspectReference, A_0);
			}
		}
		if (list.Count > 0)
		{
			this.j[A_0.b] = list;
			return true;
		}
		return false;
	}

	// Token: 0x06006B32 RID: 27442 RVA: 0x002D1468 File Offset: 0x002CF668
	private void a(EntityAspectReference<bm6, bm6> A_0, asf A_1)
	{
		if (A_0.ao() != null)
		{
			A_0.ao().y6()[ddq.ai] = A_1.a;
		}
	}

	// Token: 0x06006B33 RID: 27443 RVA: 0x002D149C File Offset: 0x002CF69C
	private List<EntityAspectReference<bm6, bm6>> a(int A_0)
	{
		List<EntityAspectReference<bm6, bm6>> list = new List<EntityAspectReference<bm6, bm6>>();
		while (this.i.Count > 0 && list.Count < A_0)
		{
			int index = zp.a.Next(this.i.Count);
			EntityAspectReference<bm6, bm6> entityAspectReference = this.i[index];
			this.i.RemoveAt(index);
			if (entityAspectReference.ao() != null)
			{
				list.Add(entityAspectReference);
			}
		}
		return list;
	}

	// Token: 0x06006B34 RID: 27444 RVA: 0x002D1510 File Offset: 0x002CF710
	private bool a(asf A_0)
	{
		List<EntityAspectReference<bm6, bm6>> list;
		this.j.TryGetValue(A_0.b, out list);
		if (list != null)
		{
			for (int i = list.Count - 1; i >= 0; i--)
			{
				EntityAspectReference<bm6, bm6> entityAspectReference = list[i];
				if (entityAspectReference.ao() != null)
				{
					this.a(entityAspectReference, A_0);
				}
				else
				{
					list.RemoveAt(i);
				}
			}
			if (list.Count < this.b)
			{
				foreach (EntityAspectReference<bm6, bm6> entityAspectReference2 in this.a(this.b - list.Count))
				{
					if (entityAspectReference2.ao() != null)
					{
						this.a(entityAspectReference2, A_0);
						list.Add(entityAspectReference2);
					}
				}
			}
			if (list.Count == 0)
			{
				this.j.Remove(A_0.b);
				return false;
			}
		}
		return false;
	}

	// Token: 0x04002BFC RID: 11260
	private string a;

	// Token: 0x04002BFD RID: 11261
	private int b = 1;

	// Token: 0x04002BFE RID: 11262
	private int c = 5000;

	// Token: 0x04002BFF RID: 11263
	private int d = 1000;

	// Token: 0x04002C00 RID: 11264
	private int e;

	// Token: 0x04002C01 RID: 11265
	private double f;

	// Token: 0x04002C02 RID: 11266
	private double g;

	// Token: 0x04002C03 RID: 11267
	private Queue<asf> h = new Queue<asf>();

	// Token: 0x04002C04 RID: 11268
	private List<EntityAspectReference<bm6, bm6>> i = new List<EntityAspectReference<bm6, bm6>>();

	// Token: 0x04002C05 RID: 11269
	private Dictionary<Guid, List<EntityAspectReference<bm6, bm6>>> j = new Dictionary<Guid, List<EntityAspectReference<bm6, bm6>>>();

	// Token: 0x04002C06 RID: 11270
	private List<cze> k = new List<cze>();
}
