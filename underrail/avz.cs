using System;
using System.Runtime.Serialization;

// Token: 0x0200192E RID: 6446
[eiz("BSI")]
[Serializable]
public sealed class avz : dj3, ISerializable
{
	// Token: 0x060088C3 RID: 35011 RVA: 0x00388594 File Offset: 0x00386794
	private avz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("BSI:BN");
			return;
		}
		if (base.GetType() == typeof(avz))
		{
			this.a = A_0.GetString("_BlueprintName");
			return;
		}
		this.a = A_0.GetString("BlueprintStorageItem+_BlueprintName");
	}

	// Token: 0x060088C4 RID: 35012 RVA: 0x00388604 File Offset: 0x00386804
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("BSI:BN", this.a);
	}

	// Token: 0x060088C5 RID: 35013 RVA: 0x00388620 File Offset: 0x00386820
	public string b()
	{
		return this.a;
	}

	// Token: 0x060088C6 RID: 35014 RVA: 0x00388628 File Offset: 0x00386828
	public new void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060088C7 RID: 35015 RVA: 0x00388634 File Offset: 0x00386834
	public override string tv()
	{
		return "Чертёж";
	}

	// Token: 0x060088C8 RID: 35016 RVA: 0x0038863C File Offset: 0x0038683C
	public avz()
	{
		this.a();
	}

	// Token: 0x060088C9 RID: 35017 RVA: 0x0038864C File Offset: 0x0038684C
	public avz(string A_0) : this()
	{
		this.a = A_0;
	}

	// Token: 0x060088CA RID: 35018 RVA: 0x00388660 File Offset: 0x00386860
	public override bk3 tw()
	{
		avz avz = new avz();
		this.ai7(avz);
		return avz;
	}

	// Token: 0x060088CB RID: 35019 RVA: 0x0038867C File Offset: 0x0038687C
	private new void a()
	{
		base.a2().Add(new aia(typeof(jb)));
	}

	// Token: 0x060088CC RID: 35020 RVA: 0x0038869C File Offset: 0x0038689C
	protected override void ai7(bk3 A_0)
	{
		base.ai7(A_0);
		avz avz = A_0 as avz;
		if (avz != null)
		{
			avz.a = this.a;
		}
	}

	// Token: 0x04003693 RID: 13971
	private new string a;
}
