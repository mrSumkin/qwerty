using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x02000F85 RID: 3973
[eiz("DWREA")]
[Serializable]
public sealed class dw8 : Aspect<c5x>, cmm, bp1
{
	// Token: 0x060050DF RID: 20703 RVA: 0x002468C8 File Offset: 0x00244AC8
	private dw8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetDouble("DWREA:T");
		this.c = A_0.GetBoolean("DWREA:I");
		di7.ReadList<edx>("DWREA:L", ref this.d, A_0);
	}

	// Token: 0x060050E0 RID: 20704 RVA: 0x0024691C File Offset: 0x00244B1C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DWREA:T", this.b);
		info.AddValue("DWREA:I", this.c);
		di7.WriteList<edx>("DWREA:L", this.d, info);
	}

	// Token: 0x060050E1 RID: 20705 RVA: 0x00246964 File Offset: 0x00244B64
	public dw8(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060050E2 RID: 20706 RVA: 0x00246978 File Offset: 0x00244B78
	public void c9(TimeSpan A_0)
	{
		this.b += A_0.TotalMinutes;
		this.a();
	}

	// Token: 0x060050E3 RID: 20707 RVA: 0x00246994 File Offset: 0x00244B94
	public void da(TimeSpan A_0)
	{
	}

	// Token: 0x060050E4 RID: 20708 RVA: 0x00246998 File Offset: 0x00244B98
	public void r7(eds A_0)
	{
	}

	// Token: 0x060050E5 RID: 20709 RVA: 0x0024699C File Offset: 0x00244B9C
	public void mx()
	{
		if (!this.c)
		{
			this.c = true;
			this.d = new List<edx>();
			foreach (aud aud in base.a8().Zone.Areas)
			{
				foreach (b0b b0b in aud.Entities)
				{
					c5x c5x = (c5x)b0b;
					amc aspect = c5x.GetAspect<amc>();
					if (aspect != null && (aspect.am() == bln.er || aspect.am() == bln.eq))
					{
						this.d.Add(new edx(Enumerable.FirstOrDefault<ak1>(c5x.l)));
					}
				}
			}
		}
	}

	// Token: 0x060050E6 RID: 20710 RVA: 0x00246AB0 File Offset: 0x00244CB0
	public void my()
	{
	}

	// Token: 0x060050E7 RID: 20711 RVA: 0x00246AB4 File Offset: 0x00244CB4
	private void a()
	{
		if (this.b >= (double)dw8.a)
		{
			int num = 0;
			foreach (aud aud in base.a8().Zone.Areas)
			{
				foreach (b0b b0b in aud.Entities)
				{
					amc aspect = ((c5x)b0b).GetAspect<amc>();
					if (aspect != null && aspect.am() == bln.er)
					{
						num++;
					}
				}
			}
			List<ak1> list = new List<ak1>();
			using (List<edx>.Enumerator enumerator3 = this.d.GetEnumerator())
			{
				while (enumerator3.MoveNext())
				{
					edx edx = enumerator3.Current;
					if (edx.ao() != null && !aw1.a(null, edx.ao(), false, null))
					{
						list.Add(edx.ao());
					}
				}
				goto IL_1C5;
			}
			IL_11A:
			this.b -= (double)dw8.a;
			ak1 ak = list[cuo.a.Next(list.Count)];
			c5x c5x = vq.a("Creature\\Critters\\BurrowedDeepWorm", false);
			if (c5x != null)
			{
				c5x.Layer = aju.x;
				c5x.Location = ak.Location.a();
				dtb dtb = new dtb();
				dtb.ad().Add(new a4s(new bk6(ak.Area, c5x), null, null, null));
				base.a8().Zone.ActionManager.g9(dtb, atp.a);
				list.Remove(ak);
			}
			IL_1C5:
			if (this.b >= (double)dw8.a && list.Count > 0)
			{
				goto IL_11A;
			}
			this.b = Math.Min(this.b, (double)(this.d.Count * dw8.a));
		}
	}

	// Token: 0x04002126 RID: 8486
	private static readonly int a = 15;

	// Token: 0x04002127 RID: 8487
	private double b;

	// Token: 0x04002128 RID: 8488
	private bool c;

	// Token: 0x04002129 RID: 8489
	private List<edx> d = new List<edx>();
}
