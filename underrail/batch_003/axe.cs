using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;

// Token: 0x02001149 RID: 4425
[eiz("RAMJUM")]
[Serializable]
public sealed class axe : Aspect<c5x>, ISerializable, c98
{
	// Token: 0x06005ED6 RID: 24278 RVA: 0x0028257C File Offset: 0x0028077C
	private axe(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005ED7 RID: 24279 RVA: 0x00282588 File Offset: 0x00280788
	public axe(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06005ED8 RID: 24280 RVA: 0x00282594 File Offset: 0x00280794
	public void a()
	{
		if (bpo.GetService<cnk>() != null)
		{
			this.a(0f);
			return;
		}
		this.a(1f);
	}

	// Token: 0x06005ED9 RID: 24281 RVA: 0x002825B8 File Offset: 0x002807B8
	public void b()
	{
		if (bpo.GetService<cnk>() != null)
		{
			this.a(0f);
			return;
		}
		this.a(1f);
	}

	// Token: 0x06005EDA RID: 24282 RVA: 0x002825DC File Offset: 0x002807DC
	public void r7(eds A_0)
	{
		if (base.a8() != null && base.a8().p.b != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			bo9 bo = null;
			float num = float.MaxValue;
			foreach (ya ya in base.a8().Area.Triggers)
			{
				bo9 bo2 = ya as bo9;
				if (bo2 != null)
				{
					float num2 = bnx.a(base.a8().aj().a(), bo2.Location);
					if (num2 < num)
					{
						bo = bo2;
						num = num2;
					}
				}
			}
			if (bo != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().Area == base.a8().Area && base.a8().c(dm9.b))
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.h.b != null && c5x.h.b.aa().Vehicle != null)
				{
					if (base.a8() != null && base.a8().p.b != null && base.a8().p.b.a.Count > 0)
					{
						int index = this.a(base.a8());
						float num3;
						if (bo.a(c5x.h.b, out num3))
						{
							base.a8().p.b.a[index].c = new Color?(new Color(0, 0, 255));
							etz etz = base.a8().p.b.a[index] as etz;
							if (etz != null)
							{
								etz.d(175);
							}
						}
						else
						{
							base.a8().p.b.a[index].c = new Color?(new Color(255, 0, 0));
							etz etz2 = base.a8().p.b.a[index] as etz;
							if (etz2 != null)
							{
								etz2.d(250);
							}
						}
					}
					double num4 = aw1.b(base.a8(), serviceOrThrow.aqu().v().b());
					float a_ = d05.b(0f, (float)(7.5 - num4) / 5f, 0.6f);
					this.a(a_, A_0.b.TotalMilliseconds);
					return;
				}
			}
			this.a(0f);
		}
	}

	// Token: 0x06005EDB RID: 24283 RVA: 0x002828F8 File Offset: 0x00280AF8
	private void a(float A_0)
	{
		if (base.a8() != null && base.a8().p.b != null && base.a8().p.b.a.Count > 0)
		{
			int index = this.a(base.a8());
			base.a8().p.b.a[index].d = new float?(A_0);
		}
	}

	// Token: 0x06005EDC RID: 24284 RVA: 0x00282978 File Offset: 0x00280B78
	private int a(c5x A_0)
	{
		int result;
		if (A_0 != null && A_0.p.b.a.Count > 1)
		{
			result = 1;
		}
		else
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06005EDD RID: 24285 RVA: 0x002829B0 File Offset: 0x00280BB0
	private void a(float A_0, double A_1)
	{
		if (base.a8() != null && base.a8().p.b != null && base.a8().p.b.a.Count > 0)
		{
			int index = this.a(base.a8());
			float valueOrDefault = base.a8().p.b.a[index].d.GetValueOrDefault(1f);
			float num = (float)(A_1 * 0.001);
			if (valueOrDefault < A_0)
			{
				this.a(Math.Min(A_0, base.a8().p.b.a[index].d.GetValueOrDefault(1f) + num));
				return;
			}
			if (valueOrDefault > A_0)
			{
				this.a(Math.Max(A_0, base.a8().p.b.a[index].d.GetValueOrDefault(1f) - num));
			}
		}
	}
}
