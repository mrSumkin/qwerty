using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001688 RID: 5768
[eiz("TXGA")]
[Serializable]
public sealed class eip : h3, ISerializable, cuu
{
	// Token: 0x06007DCC RID: 32204 RVA: 0x00351F94 File Offset: 0x00350194
	private eip(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<Guid>("TXGA:A", ref this.a, A_0);
		this.b = (Point)A_0.GetValue("TXGA:S", typeof(Point));
	}

	// Token: 0x06007DCD RID: 32205 RVA: 0x00351FE8 File Offset: 0x003501E8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<Guid>("TXGA:A", this.a, info);
		info.AddValue("TXGA:S", this.b);
	}

	// Token: 0x06007DCE RID: 32206 RVA: 0x0035201C File Offset: 0x0035021C
	public eip()
	{
	}

	// Token: 0x06007DCF RID: 32207 RVA: 0x00352034 File Offset: 0x00350234
	public override void cq(aud A_0, Point A_1, float A_2)
	{
		ak1 ak = A_0.b(A_1.X, A_1.Y);
		if (ak != null)
		{
			double num = (double)(2f - A_2);
			num *= 0.75 + 0.5 * cuo.a.NextDouble();
			num = d05.b(1.0, num, 4.0);
			bpv.a("poisonedGas", num, ak, null, false, false, new double?((double)dz6.b(Convert.ToInt32(250f + A_2 * 100f))));
			foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
			{
				c5x c5x = b0b as c5x;
				if (c5x != null && c5x.h.b != null && !this.a.Contains(b0b.qe()))
				{
					this.a(c5x.h.b, A_2);
					this.a.Add(c5x.qe());
				}
			}
		}
	}

	// Token: 0x06007DD0 RID: 32208 RVA: 0x00352170 File Offset: 0x00350370
	private void a(amc A_0, float A_1)
	{
	}

	// Token: 0x040031D1 RID: 12753
	private new List<Guid> a = new List<Guid>();

	// Token: 0x040031D2 RID: 12754
	private Point b;
}
