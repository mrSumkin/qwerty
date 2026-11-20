using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x020019AA RID: 6570
[eiz("IFX")]
[Serializable]
public abstract class dbj : ISerializable, ICloneable
{
	// Token: 0x06008C43 RID: 35907 RVA: 0x00390F4C File Offset: 0x0038F14C
	protected dbj(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetInt32("IFX:R");
	}

	// Token: 0x06008C44 RID: 35908 RVA: 0x00390F68 File Offset: 0x0038F168
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("IFX:R", this.a);
	}

	// Token: 0x17000223 RID: 547
	// (get) Token: 0x06008C45 RID: 35909 RVA: 0x00390F7C File Offset: 0x0038F17C
	// (set) Token: 0x06008C46 RID: 35910 RVA: 0x00390F84 File Offset: 0x0038F184
	public int RemainingTicks
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

	// Token: 0x17000224 RID: 548
	// (get) Token: 0x06008C47 RID: 35911
	public abstract string Code { get; }

	// Token: 0x17000225 RID: 549
	// (get) Token: 0x06008C48 RID: 35912
	public abstract string Name { get; }

	// Token: 0x17000226 RID: 550
	// (get) Token: 0x06008C49 RID: 35913 RVA: 0x00390F90 File Offset: 0x0038F190
	public virtual aa6 Stacking
	{
		get
		{
			return aa6.a;
		}
	}

	// Token: 0x17000227 RID: 551
	// (get) Token: 0x06008C4A RID: 35914 RVA: 0x00390F94 File Offset: 0x0038F194
	public virtual string CategoryCode
	{
		get
		{
			return null;
		}
	}

	// Token: 0x17000228 RID: 552
	// (get) Token: 0x06008C4B RID: 35915 RVA: 0x00390F98 File Offset: 0x0038F198
	public virtual bool ShowTicks
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17000229 RID: 553
	// (get) Token: 0x06008C4C RID: 35916
	public abstract SpellTargetType TargetType { get; }

	// Token: 0x1700022A RID: 554
	// (get) Token: 0x06008C4D RID: 35917 RVA: 0x00390F9C File Offset: 0x0038F19C
	public virtual string Icon
	{
		get
		{
			return string.Empty;
		}
	}

	// Token: 0x06008C4E RID: 35918 RVA: 0x00390FA4 File Offset: 0x0038F1A4
	public dbj()
	{
	}

	// Token: 0x06008C4F RID: 35919 RVA: 0x00390FAC File Offset: 0x0038F1AC
	public dbj(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008C50 RID: 35920 RVA: 0x00390FBC File Offset: 0x0038F1BC
	public virtual void ajq(coh A_0)
	{
	}

	// Token: 0x06008C51 RID: 35921 RVA: 0x00390FC0 File Offset: 0x0038F1C0
	public virtual bool qm(bool A_0)
	{
		return false;
	}

	// Token: 0x06008C52 RID: 35922 RVA: 0x00390FC4 File Offset: 0x0038F1C4
	public virtual bool aif(bool A_0)
	{
		return false;
	}

	// Token: 0x06008C53 RID: 35923 RVA: 0x00390FC8 File Offset: 0x0038F1C8
	public virtual void aie(efk A_0, efk A_1, cd1 A_2, bool A_3, cmn A_4)
	{
	}

	// Token: 0x06008C54 RID: 35924 RVA: 0x00390FCC File Offset: 0x0038F1CC
	public virtual void ajr(efk A_0, efk A_1, cd1 A_2, bool A_3, cmn A_4)
	{
	}

	// Token: 0x06008C55 RID: 35925 RVA: 0x00390FD0 File Offset: 0x0038F1D0
	public virtual List<edm> qo(cd1 A_0, bool A_1)
	{
		return null;
	}

	// Token: 0x06008C56 RID: 35926 RVA: 0x00390FD4 File Offset: 0x0038F1D4
	public dbj b()
	{
		try
		{
			dbj dbj = Activator.CreateInstance(base.GetType()) as dbj;
			if (dbj != null)
			{
				this.a(dbj);
				return dbj;
			}
		}
		catch
		{
		}
		return null;
	}

	// Token: 0x06008C57 RID: 35927 RVA: 0x00391024 File Offset: 0x0038F224
	public string a(cnm A_0)
	{
		efk a_;
		if (A_0 != null)
		{
			a_ = A_0.b8();
		}
		else
		{
			a_ = null;
		}
		return this.gc(a_);
	}

	// Token: 0x06008C58 RID: 35928
	public abstract string gc(efk A_0);

	// Token: 0x06008C59 RID: 35929 RVA: 0x0039104C File Offset: 0x0038F24C
	public virtual string gd(efk A_0)
	{
		return "";
	}

	// Token: 0x06008C5A RID: 35930 RVA: 0x00391054 File Offset: 0x0038F254
	public virtual string ae7(efk A_0, coh A_1)
	{
		return this.gd(A_0);
	}

	// Token: 0x06008C5B RID: 35931 RVA: 0x00391060 File Offset: 0x0038F260
	public override string ToString()
	{
		return this.ae7(null, null);
	}

	// Token: 0x06008C5C RID: 35932 RVA: 0x0039106C File Offset: 0x0038F26C
	public virtual string qn(coh A_0)
	{
		return null;
	}

	// Token: 0x06008C5D RID: 35933 RVA: 0x00391070 File Offset: 0x0038F270
	protected virtual void a(dbj A_0)
	{
		A_0.a = this.a;
	}

	// Token: 0x06008C5E RID: 35934 RVA: 0x00391080 File Offset: 0x0038F280
	object ICloneable.e()
	{
		return this.b();
	}

	// Token: 0x06008C5F RID: 35935 RVA: 0x00391088 File Offset: 0x0038F288
	public virtual int abe(coh A_0)
	{
		return 1;
	}

	// Token: 0x0400379C RID: 14236
	private int a;
}
