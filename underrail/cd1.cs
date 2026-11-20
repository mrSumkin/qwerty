using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001945 RID: 6469
[eiz("WII")]
[Serializable]
public sealed class cd1 : a06, IItemInstance<bke>, ISerializable
{
	// Token: 0x06008957 RID: 35159 RVA: 0x00389BBC File Offset: 0x00387DBC
	private cd1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 51)
		{
			di7.ReadList<AmmoType>("WII:A", ref this.a, A_0);
		}
	}

	// Token: 0x06008958 RID: 35160 RVA: 0x00389BF0 File Offset: 0x00387DF0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<AmmoType>("WII:A", this.a, info);
	}

	// Token: 0x17000213 RID: 531
	// (get) Token: 0x06008959 RID: 35161 RVA: 0x00389C0C File Offset: 0x00387E0C
	[Browsable(false)]
	public bke TypedDefinition
	{
		get
		{
			return base.Definition as bke;
		}
	}

	// Token: 0x17000214 RID: 532
	// (get) Token: 0x0600895A RID: 35162 RVA: 0x00389C1C File Offset: 0x00387E1C
	// (set) Token: 0x0600895B RID: 35163 RVA: 0x00389C24 File Offset: 0x00387E24
	public List<AmmoType> LoadedAmmo
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

	// Token: 0x17000215 RID: 533
	// (get) Token: 0x0600895C RID: 35164 RVA: 0x00389C30 File Offset: 0x00387E30
	public AmmoType CurrentBullet
	{
		get
		{
			if (this.a != null && this.a.Count > 0)
			{
				return this.a[this.a.Count - 1];
			}
			if (this.TypedDefinition != null)
			{
				return this.TypedDefinition.ak();
			}
			return AmmoType.None;
		}
	}

	// Token: 0x0600895D RID: 35165 RVA: 0x00389C8C File Offset: 0x00387E8C
	public cd1(bit A_0) : base(A_0)
	{
	}

	// Token: 0x0600895E RID: 35166 RVA: 0x00389CA4 File Offset: 0x00387EA4
	public override coh fy()
	{
		cd1 cd = new cd1(base.DefinitionProvider.wm());
		this.fz(cd);
		return cd;
	}

	// Token: 0x0600895F RID: 35167 RVA: 0x00389CCC File Offset: 0x00387ECC
	protected override double afc()
	{
		if (this.TypedDefinition != null && this.TypedDefinition.ao && base.Durability == 0.0)
		{
			return 0.0001;
		}
		return base.afc();
	}

	// Token: 0x06008960 RID: 35168 RVA: 0x00389D18 File Offset: 0x00387F18
	protected override void fz(coh A_0)
	{
		base.fz(A_0);
		cd1 cd = A_0 as cd1;
		if (this.a != null)
		{
			cd.a = new List<AmmoType>(this.a);
			return;
		}
		cd.a = null;
	}

	// Token: 0x040036AE RID: 13998
	private new List<AmmoType> a = new List<AmmoType>();
}
