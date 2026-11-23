using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x020019AB RID: 6571
[eiz("FRCCIE")]
[Serializable]
public sealed class dma : dbj
{
	// Token: 0x06008C60 RID: 35936 RVA: 0x0039108C File Offset: 0x0038F28C
	private dma(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008C61 RID: 35937 RVA: 0x00391098 File Offset: 0x0038F298
	public dma()
	{
	}

	// Token: 0x06008C62 RID: 35938 RVA: 0x003910A0 File Offset: 0x0038F2A0
	public override string f9()
	{
		return "firecrackerCap";
	}

	// Token: 0x06008C63 RID: 35939 RVA: 0x003910A8 File Offset: 0x0038F2A8
	public override string ga()
	{
		return "Взрывчатая накладка";
	}

	// Token: 0x06008C64 RID: 35940 RVA: 0x003910B0 File Offset: 0x0038F2B0
	public override string qj()
	{
		return "Explosive";
	}

	// Token: 0x06008C65 RID: 35941 RVA: 0x003910B8 File Offset: 0x0038F2B8
	public override SpellTargetType qk()
	{
		return SpellTargetType.ExplosiveCompatibleWeapon;
	}

	// Token: 0x06008C66 RID: 35942 RVA: 0x003910C0 File Offset: 0x0038F2C0
	public override string ql()
	{
		return "FirecrackerCap";
	}

	// Token: 0x06008C67 RID: 35943 RVA: 0x003910C8 File Offset: 0x0038F2C8
	public override bool qm(bool A_0)
	{
		return A_0;
	}

	// Token: 0x06008C68 RID: 35944 RVA: 0x003910CC File Offset: 0x0038F2CC
	public override string qn(coh A_0)
	{
		return "ApplyFirecrackerCap";
	}

	// Token: 0x06008C69 RID: 35945 RVA: 0x003910D8 File Offset: 0x0038F2D8
	public override string gc(efk A_0)
	{
		edm a_ = dma.a();
		string text = new aaj().e1(a_);
		text = text.Substring(0, 1).ToLowerInvariant() + text.Substring(1);
		return string.Format("Задействует специальную накладку на дробящем оружии ближнего боя, которая {0}", text);
	}

	// Token: 0x06008C6A RID: 35946 RVA: 0x0039111C File Offset: 0x0038F31C
	public static edm a()
	{
		return new edm("firecrackerCapExplosiveHit", 1.0, 200, true);
	}

	// Token: 0x06008C6B RID: 35947 RVA: 0x00391138 File Offset: 0x0038F338
	public override string ae7(efk A_0, coh A_1)
	{
		edm a_ = dma.a();
		string text = new aaj().e1(a_);
		text = text.Substring(0, 1).ToLowerInvariant() + text.Substring(1);
		return string.Format("Ваши атаки задействуют специальную накладку, которая {0}", text);
	}

	// Token: 0x06008C6C RID: 35948 RVA: 0x0039117C File Offset: 0x0038F37C
	public override List<edm> qo(cd1 A_0, bool A_1)
	{
		if (A_1)
		{
			return new List<edm>
			{
				dma.a()
			};
		}
		return null;
	}
}
