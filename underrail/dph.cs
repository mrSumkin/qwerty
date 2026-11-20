using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001DD6 RID: 7638
[eiz("AC")]
[Serializable]
public class dph : ISerializable
{
	// Token: 0x0600A8FF RID: 43263 RVA: 0x003EF398 File Offset: 0x003ED598
	protected dph(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadList<els>("AC:SE", ref this.a, A_0);
			this.b = (cnm)A_0.GetValue("AC:IS", typeof(cnm));
			return;
		}
		if (base.GetType() == typeof(dph))
		{
			this.a = (List<els>)A_0.GetValue("_StatusEffects", typeof(List<els>));
			this.b = (cnm)A_0.GetValue("_InvocationSet", typeof(cnm));
			return;
		}
		this.a = (List<els>)A_0.GetValue("AuraContext+_StatusEffects", typeof(List<els>));
		this.b = (cnm)A_0.GetValue("AuraContext+_InvocationSet", typeof(cnm));
	}

	// Token: 0x0600A900 RID: 43264 RVA: 0x003EF484 File Offset: 0x003ED684
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteList<els>("AC:SE", this.a, info);
		info.AddValue("AC:IS", this.b);
	}

	// Token: 0x170002A2 RID: 674
	// (get) Token: 0x0600A901 RID: 43265 RVA: 0x003EF4A8 File Offset: 0x003ED6A8
	public List<els> StatusEffects
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x170002A3 RID: 675
	// (get) Token: 0x0600A902 RID: 43266 RVA: 0x003EF4B0 File Offset: 0x003ED6B0
	public cnm InvocationSet
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x0600A903 RID: 43267 RVA: 0x003EF4B8 File Offset: 0x003ED6B8
	public dph(cnm A_0, List<els> A_1)
	{
		czh.a(A_0, "invocationSet");
		czh.a(A_1, "statusEffects");
		this.a = A_1;
		this.b = A_0;
	}

	// Token: 0x04003F2F RID: 16175
	private List<els> a;

	// Token: 0x04003F30 RID: 16176
	private cnm b;
}
