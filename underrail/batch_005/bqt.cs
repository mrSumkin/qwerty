using System;
using System.Collections.Generic;
using Ouroboros.Core.Logging;

// Token: 0x02000244 RID: 580
public sealed class bqt : dcm
{
	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x06001088 RID: 4232 RVA: 0x0004438C File Offset: 0x0004258C
	public bool Initialized
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x06001089 RID: 4233 RVA: 0x00044394 File Offset: 0x00042594
	public ya Trigger
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x0600108A RID: 4234 RVA: 0x0004439C File Offset: 0x0004259C
	public bqt(ya A_0)
	{
		czh.a(A_0, "trigger");
		this.b = A_0;
	}

	// Token: 0x0600108B RID: 4235 RVA: 0x000443D0 File Offset: 0x000425D0
	public bool bc(bool A_0)
	{
		if (this.a)
		{
			return false;
		}
		if (!this.b.Deployed)
		{
			cvq cvq = dr3.e();
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 112))
			{
				string a_ = string.Format("[Playfield] - Attempted to initialize proxy for a trigger ('{0}') that was not deployed.", this.b.Name);
				cvq.n7(LogSeverity.Error, 112, a_);
			}
			return false;
		}
		this.c = new List<ak1>();
		this.d = new Dictionary<b0b, HashSet<ak1>>();
		for (int i = this.b.Location.Y; i < this.b.Location.Y + this.b.Size.d; i++)
		{
			for (int j = this.b.Location.X; j < this.b.Location.X + this.b.Size.c; j++)
			{
				ak1 ak = this.b.Area.b(j, i);
				if (ak != null)
				{
					ak.a(this);
					this.c.Add(ak);
					foreach (b0b b0b in ak.Entities)
					{
						if (b0b.CanTrigger)
						{
							this.a(b0b);
						}
					}
				}
			}
		}
		this.a = true;
		return true;
	}

	// Token: 0x0600108C RID: 4236 RVA: 0x00044570 File Offset: 0x00042770
	public bool bd(bool A_0)
	{
		if (!this.a)
		{
			return false;
		}
		if (!this.b.Deployed)
		{
			cvq cvq = dr3.e();
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 112))
			{
				string a_ = string.Format("[Playfield] - Attempted to uninitialize proxy for a trigger ('{0}') that was not deployed.", this.b.Name);
				cvq.n7(LogSeverity.Error, 112, a_);
			}
			return false;
		}
		foreach (ak1 ak in this.c)
		{
			ak.b(this);
		}
		this.c.Clear();
		this.d.Clear();
		this.a = false;
		return true;
	}

	// Token: 0x0600108D RID: 4237 RVA: 0x0004464C File Offset: 0x0004284C
	public void b(ak1 A_0, b0b A_1)
	{
		czh.a(A_0, "tile");
		czh.a(A_1, "entity");
		HashSet<ak1> hashSet;
		this.d.TryGetValue(A_1, out hashSet);
		if (hashSet == null)
		{
			hashSet = new HashSet<ak1>();
			this.d[A_1] = hashSet;
		}
		if (hashSet.Count == 0 && this.a())
		{
			this.b.e(A_1);
		}
		hashSet.Add(A_0);
	}

	// Token: 0x0600108E RID: 4238 RVA: 0x000446C4 File Offset: 0x000428C4
	internal void a(ak1 A_0, b0b A_1)
	{
		czh.a(A_0, "tile");
		czh.a(A_1, "entity");
		this.b.g(A_1);
	}

	// Token: 0x0600108F RID: 4239 RVA: 0x000446EC File Offset: 0x000428EC
	public void c(ak1 A_0, b0b A_1)
	{
		czh.a(A_0, "tile");
		czh.a(A_1, "entity");
		HashSet<ak1> hashSet;
		this.d.TryGetValue(A_1, out hashSet);
		if (hashSet == null)
		{
			cvq cvq = dr3.e();
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 112))
			{
				string a_ = string.Format("[Playfield] - Trigger proxy ('{0}') was notified of an entity exiting ('{1}'), but the entity was not being tracked by the proxy.", this.b.Name, A_1.ToString());
				cvq.n7(LogSeverity.Error, 112, a_);
			}
			return;
		}
		if (!hashSet.Remove(A_0))
		{
			cvq cvq2 = dr3.e();
			if (cvq2 != null && cvq2.n8() && cvq2.n9(LogSeverity.Error, 112))
			{
				string a_2 = string.Format("[Playfield] - Trigger proxy ('{0}') was notified of an entity exiting ('{1}'), but the entity was not being tracked as occupying the specified tile ('{2}')", this.b.Name, A_1.ToString(), A_0.ToString());
				cvq2.n7(LogSeverity.Error, 112, a_2);
			}
			return;
		}
		if (hashSet.Count == 0)
		{
			if (this.a())
			{
				this.b.f(A_1);
			}
			this.d.Remove(A_1);
		}
	}

	// Token: 0x06001090 RID: 4240 RVA: 0x00044800 File Offset: 0x00042A00
	public void b(b0b A_0)
	{
		czh.a(A_0, "entity");
		this.b.h(A_0);
	}

	// Token: 0x06001091 RID: 4241 RVA: 0x0004481C File Offset: 0x00042A1C
	private void a(b0b A_0)
	{
		czh.a(A_0, "entity");
		HashSet<ak1> hashSet;
		this.d.TryGetValue(A_0, out hashSet);
		if (hashSet == null)
		{
			hashSet = new HashSet<ak1>();
			this.d[A_0] = hashSet;
		}
		foreach (ak1 ak in A_0.l)
		{
			if (this.c.Contains(ak))
			{
				hashSet.Add(ak);
			}
		}
	}

	// Token: 0x06001092 RID: 4242 RVA: 0x000448BC File Offset: 0x00042ABC
	private bool a()
	{
		if (!this.Trigger.Area.Initialized)
		{
			return false;
		}
		d6j service = bpo.GetService<d6j>();
		return service == null || !service.dw();
	}

	// Token: 0x04000985 RID: 2437
	private bool a;

	// Token: 0x04000986 RID: 2438
	private ya b;

	// Token: 0x04000987 RID: 2439
	private List<ak1> c = new List<ak1>();

	// Token: 0x04000988 RID: 2440
	private Dictionary<b0b, HashSet<ak1>> d = new Dictionary<b0b, HashSet<ak1>>();
}
