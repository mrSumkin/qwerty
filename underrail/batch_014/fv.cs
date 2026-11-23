using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001962 RID: 6498
[eiz("CII")]
[Serializable]
public sealed class fv : d48, IItemInstance<a1k>, ISerializable, eyk
{
	// Token: 0x06008AF6 RID: 35574 RVA: 0x0038E4F0 File Offset: 0x0038C6F0
	private fv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetInt32("CII:QL");
			return;
		}
		if (base.GetType() == typeof(fv))
		{
			this.a = A_0.GetInt32("_QualityLevel");
			return;
		}
		this.a = A_0.GetInt32("ComponentItemInstance+_QualityLevel");
	}

	// Token: 0x06008AF7 RID: 35575 RVA: 0x0038E560 File Offset: 0x0038C760
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CII:QL", this.a);
	}

	// Token: 0x1700021B RID: 539
	// (get) Token: 0x06008AF8 RID: 35576 RVA: 0x0038E57C File Offset: 0x0038C77C
	[Browsable(false)]
	public a1k TypedDefinition
	{
		get
		{
			return base.Definition as a1k;
		}
	}

	// Token: 0x1700021C RID: 540
	// (get) Token: 0x06008AF9 RID: 35577 RVA: 0x0038E58C File Offset: 0x0038C78C
	// (set) Token: 0x06008AFA RID: 35578 RVA: 0x0038E594 File Offset: 0x0038C794
	public int QualityLevel
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x06008AFB RID: 35579 RVA: 0x0038E5A0 File Offset: 0x0038C7A0
	public fv(bit A_0) : base(A_0)
	{
	}

	// Token: 0x06008AFC RID: 35580 RVA: 0x0038E5AC File Offset: 0x0038C7AC
	public Dictionary<string, int> a()
	{
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		if (this.TypedDefinition != null && this.TypedDefinition.g() != null)
		{
			foreach (b8w b8w in this.TypedDefinition.g())
			{
				if (!string.IsNullOrEmpty(b8w.SkillName) && b8w.Factor >= 0f)
				{
					double num = (double)Math.Max(0, this.QualityLevel - dwh.z);
					double num2 = Math.Min(1.0, num / (double)dwh.ab);
					num2 = Math.Pow(num2, dwh.x);
					double num3 = dwh.v + dwh.y * num2;
					dictionary[b8w.SkillName] = (int)((double)b8w.Factor * ((this.QualityLevel > 0) ? ((double)this.QualityLevel * num3) : 1.0));
				}
			}
		}
		return dictionary;
	}

	// Token: 0x06008AFD RID: 35581 RVA: 0x0038E6CC File Offset: 0x0038C8CC
	public override bool fx(mp A_0)
	{
		fv fv = A_0 as fv;
		return fv != null && base.fx(A_0) && this.QualityLevel == fv.QualityLevel;
	}

	// Token: 0x06008AFE RID: 35582 RVA: 0x0038E704 File Offset: 0x0038C904
	public override coh fy()
	{
		fv fv = new fv(base.DefinitionProvider.wm());
		this.fz(fv);
		return fv;
	}

	// Token: 0x06008AFF RID: 35583 RVA: 0x0038E72C File Offset: 0x0038C92C
	protected override void fz(coh A_0)
	{
		base.fz(A_0);
		fv fv = A_0 as fv;
		if (fv != null)
		{
			fv.a = this.a;
		}
	}

	// Token: 0x04003788 RID: 14216
	private new int a;
}
