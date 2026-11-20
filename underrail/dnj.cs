using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001E27 RID: 7719
[eiz("LRP")]
[Serializable]
public sealed class dnj : ISerializable
{
	// Token: 0x0600AAF8 RID: 43768 RVA: 0x003F53B8 File Offset: 0x003F35B8
	private dnj(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetInt32("LRP:L");
			this.b = (bn2)A_0.GetValue("LRP:BA", typeof(bn2));
			this.c = (ech)A_0.GetValue("LRP:S", typeof(ech));
			this.d = (an2)A_0.GetValue("LRP:F", typeof(an2));
			this.e = A_0.GetInt32("LRP:E");
			if (ell.a() >= 392)
			{
				di7.ReadDictionary<string, f>("LRP:X", ref this.f, A_0);
				return;
			}
			this.f = new Dictionary<string, f>();
			return;
		}
		else
		{
			if (base.GetType() == typeof(dnj))
			{
				this.a = A_0.GetInt32("_Level");
				this.b = (bn2)A_0.GetValue("_BaseAbilities", typeof(bn2));
				this.c = (ech)A_0.GetValue("_Skills", typeof(ech));
				this.d = (an2)A_0.GetValue("_Feats", typeof(an2));
				this.e = A_0.GetInt32("_Experience");
				return;
			}
			this.a = A_0.GetInt32("LevelRestorationPoint+_Level");
			this.b = (bn2)A_0.GetValue("LevelRestorationPoint+_BaseAbilities", typeof(bn2));
			this.c = (ech)A_0.GetValue("LevelRestorationPoint+_Skills", typeof(ech));
			this.d = (an2)A_0.GetValue("LevelRestorationPoint+_Feats", typeof(an2));
			this.e = A_0.GetInt32("LevelRestorationPoint+_Experience");
			return;
		}
	}

	// Token: 0x0600AAF9 RID: 43769 RVA: 0x003F55B0 File Offset: 0x003F37B0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("LRP:L", this.a);
		info.AddValue("LRP:BA", this.b);
		info.AddValue("LRP:S", this.c);
		info.AddValue("LRP:F", this.d);
		info.AddValue("LRP:E", this.e);
		di7.WriteDictionary<string, f>("LRP:X", this.f, info);
	}

	// Token: 0x0600AAFA RID: 43770 RVA: 0x003F5624 File Offset: 0x003F3824
	public int e()
	{
		return this.a;
	}

	// Token: 0x0600AAFB RID: 43771 RVA: 0x003F562C File Offset: 0x003F382C
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600AAFC RID: 43772 RVA: 0x003F5638 File Offset: 0x003F3838
	public bn2 d()
	{
		return this.b;
	}

	// Token: 0x0600AAFD RID: 43773 RVA: 0x003F5640 File Offset: 0x003F3840
	public void a(bn2 A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600AAFE RID: 43774 RVA: 0x003F564C File Offset: 0x003F384C
	public ech b()
	{
		return this.c;
	}

	// Token: 0x0600AAFF RID: 43775 RVA: 0x003F5654 File Offset: 0x003F3854
	public void a(ech A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600AB00 RID: 43776 RVA: 0x003F5660 File Offset: 0x003F3860
	public an2 a()
	{
		return this.d;
	}

	// Token: 0x0600AB01 RID: 43777 RVA: 0x003F5668 File Offset: 0x003F3868
	public void a(an2 A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600AB02 RID: 43778 RVA: 0x003F5674 File Offset: 0x003F3874
	public int c()
	{
		return this.e;
	}

	// Token: 0x0600AB03 RID: 43779 RVA: 0x003F567C File Offset: 0x003F387C
	public void b(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x0600AB04 RID: 43780 RVA: 0x003F5688 File Offset: 0x003F3888
	public Dictionary<string, f> f()
	{
		return this.f;
	}

	// Token: 0x0600AB05 RID: 43781 RVA: 0x003F5690 File Offset: 0x003F3890
	public void a(Dictionary<string, f> A_0)
	{
		this.f = A_0;
	}

	// Token: 0x0600AB06 RID: 43782 RVA: 0x003F569C File Offset: 0x003F389C
	public dnj()
	{
	}

	// Token: 0x04003FDA RID: 16346
	private int a;

	// Token: 0x04003FDB RID: 16347
	private bn2 b;

	// Token: 0x04003FDC RID: 16348
	private ech c;

	// Token: 0x04003FDD RID: 16349
	private an2 d;

	// Token: 0x04003FDE RID: 16350
	private int e;

	// Token: 0x04003FDF RID: 16351
	private Dictionary<string, f> f = new Dictionary<string, f>();
}
