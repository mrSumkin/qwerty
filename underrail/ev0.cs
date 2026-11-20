using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A5D RID: 2653
[eiz("PLXSJ")]
[Serializable]
public sealed class ev0 : cze, ISerializable
{
	// Token: 0x06003EAC RID: 16044 RVA: 0x0017A968 File Offset: 0x00178B68
	private ev0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 451)
		{
			this.a = A_0.GetString("PLXSJ:S");
		}
	}

	// Token: 0x06003EAD RID: 16045 RVA: 0x0017A994 File Offset: 0x00178B94
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PLXSJ:S", this.a);
	}

	// Token: 0x06003EAE RID: 16046 RVA: 0x0017A9B0 File Offset: 0x00178BB0
	public string a()
	{
		return this.a;
	}

	// Token: 0x06003EAF RID: 16047 RVA: 0x0017A9B8 File Offset: 0x00178BB8
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003EB0 RID: 16048 RVA: 0x0017A9C4 File Offset: 0x00178BC4
	public ev0()
	{
	}

	// Token: 0x06003EB1 RID: 16049 RVA: 0x0017A9D0 File Offset: 0x00178BD0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null)
		{
			bim aspect = c5x.GetAspect<bim>();
			if (aspect != null)
			{
				foreach (cze cze in aspect.s())
				{
					be6 be = cze as be6;
					if (be != null)
					{
						c5x.c().a(this.a ?? "LadderClimb");
						csd csd = c5x.Zone.g(be.DestinationWaypoint);
						if (csd != null && csd.Tile != null)
						{
							c5x c5x2 = Enumerable.FirstOrDefault<b0b>(csd.Tile.Entities) as c5x;
							if (c5x2 != null)
							{
								c5x2.c().a(this.a ?? "LadderClimb");
							}
						}
						return;
					}
				}
			}
		}
		c5x c5x3 = A_0 as c5x;
		if (c5x3 != null)
		{
			c5x3.c().a(this.a ?? "LadderClimb");
		}
	}

	// Token: 0x04001BC2 RID: 7106
	private new string a;
}
