using System;
using System.Collections.Generic;
using Ouroboros.Common.Data;
using Ouroboros.Playfield.References;

// Token: 0x020002A6 RID: 678
public sealed class bzv
{
	// Token: 0x060013C1 RID: 5057 RVA: 0x00052400 File Offset: 0x00050600
	public int f()
	{
		int? primitivePropertyValue = this.a.GetPrimitivePropertyValue<int>(cy1.e, null);
		if (primitivePropertyValue != null)
		{
			return primitivePropertyValue.Value;
		}
		return 0;
	}

	// Token: 0x060013C2 RID: 5058 RVA: 0x0005243C File Offset: 0x0005063C
	public void a(int A_0)
	{
		this.a.SetPropertyValue(cy1.e, A_0);
	}

	// Token: 0x060013C3 RID: 5059 RVA: 0x00052458 File Offset: 0x00050658
	public int c()
	{
		int? primitivePropertyValue = this.a.GetPrimitivePropertyValue<int>(cy1.f, null);
		if (primitivePropertyValue != null)
		{
			return primitivePropertyValue.Value;
		}
		return 0;
	}

	// Token: 0x060013C4 RID: 5060 RVA: 0x00052494 File Offset: 0x00050694
	public void b(int A_0)
	{
		this.a.SetPropertyValue(cy1.f, A_0);
	}

	// Token: 0x060013C5 RID: 5061 RVA: 0x000524B0 File Offset: 0x000506B0
	public HashSet<r0> i()
	{
		HashSet<r0> hashSet = this.a.GetClassPropertyValue<HashSet<r0>>("ControlledTiles");
		if (hashSet == null)
		{
			hashSet = new HashSet<r0>();
			this.a(hashSet);
		}
		return hashSet;
	}

	// Token: 0x060013C6 RID: 5062 RVA: 0x000524E4 File Offset: 0x000506E4
	public void a(HashSet<r0> A_0)
	{
		this.a["ControlledTiles"] = A_0;
	}

	// Token: 0x060013C7 RID: 5063 RVA: 0x000524F8 File Offset: 0x000506F8
	public bzv(PropertyCollection A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060013C8 RID: 5064 RVA: 0x00052508 File Offset: 0x00050708
	public amc g()
	{
		EntityAspectReference<amc, amc> entityAspectReference = this.a[cy1.b] as EntityAspectReference<amc, amc>;
		if (entityAspectReference != null && entityAspectReference.ao() != null && entityAspectReference.ao().a8() != null && entityAspectReference.ao().a8().Area != null && entityAspectReference.ao().a8().Area.Zone != null)
		{
			return entityAspectReference.ao();
		}
		return null;
	}

	// Token: 0x060013C9 RID: 5065 RVA: 0x00052584 File Offset: 0x00050784
	public cmb d()
	{
		return this.a.GetClassPropertyValue<cmb>(cy1.h);
	}

	// Token: 0x060013CA RID: 5066 RVA: 0x00052598 File Offset: 0x00050798
	public void a(amc A_0)
	{
		if (A_0 == null)
		{
			this.a[cy1.b] = null;
			return;
		}
		this.a[cy1.b] = new EntityAspectReference<amc, amc>(A_0);
	}

	// Token: 0x060013CB RID: 5067 RVA: 0x000525CC File Offset: 0x000507CC
	public Dictionary<Guid, blk> a()
	{
		Dictionary<Guid, blk> dictionary = this.a.GetClassPropertyValue<Dictionary<Guid, blk>>(cy1.a);
		if (dictionary == null)
		{
			dictionary = new Dictionary<Guid, blk>();
			this.a.SetPropertyValue(cy1.a, dictionary);
		}
		return dictionary;
	}

	// Token: 0x060013CC RID: 5068 RVA: 0x0005260C File Offset: 0x0005080C
	public void h()
	{
		e4w.b(this.a);
	}

	// Token: 0x060013CD RID: 5069 RVA: 0x0005261C File Offset: 0x0005081C
	public blk c(Guid A_0)
	{
		blk result;
		this.a().TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x060013CE RID: 5070 RVA: 0x0005263C File Offset: 0x0005083C
	public IEnumerable<blk> b()
	{
		return this.a().Values;
	}

	// Token: 0x060013CF RID: 5071 RVA: 0x0005264C File Offset: 0x0005084C
	public void a(Guid A_0, blk A_1)
	{
		this.a()[A_0] = A_1;
	}

	// Token: 0x060013D0 RID: 5072 RVA: 0x00052660 File Offset: 0x00050860
	public bool a(Guid A_0)
	{
		erl erl = this.d(A_0);
		return erl != null && erl.f() == cem.d;
	}

	// Token: 0x060013D1 RID: 5073 RVA: 0x00052688 File Offset: 0x00050888
	public bool e(Guid A_0)
	{
		blk blk = this.c(A_0);
		return blk != null && blk.a() != null && blk.a().f() == cem.d && blk.b();
	}

	// Token: 0x060013D2 RID: 5074 RVA: 0x000526C8 File Offset: 0x000508C8
	public erl d(Guid A_0)
	{
		blk blk = this.c(A_0);
		if (blk != null)
		{
			return blk.a();
		}
		return null;
	}

	// Token: 0x060013D3 RID: 5075 RVA: 0x000526EC File Offset: 0x000508EC
	public void b(Guid A_0)
	{
		blk blk = this.c(A_0);
		if (blk != null)
		{
			blk.a().a();
		}
	}

	// Token: 0x060013D4 RID: 5076 RVA: 0x00052714 File Offset: 0x00050914
	public void e()
	{
		this.a().Clear();
		this.h();
	}

	// Token: 0x04000AA9 RID: 2729
	private PropertyCollection a;
}
