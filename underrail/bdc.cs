using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x02001B60 RID: 7008
[eiz("IBR")]
[Serializable]
public sealed class bdc : TypedObjectReference<cwp>, ISerializable
{
	// Token: 0x060097BE RID: 38846 RVA: 0x003B2348 File Offset: 0x003B0548
	private bdc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("IBR:IBFTN");
			return;
		}
		if (base.GetType() == typeof(bdc))
		{
			this.a = A_0.GetString("_ItemBlueprintFullTypeName");
			return;
		}
		this.a = A_0.GetString("ItemBlueprintReference+_ItemBlueprintFullTypeName");
	}

	// Token: 0x060097BF RID: 38847 RVA: 0x003B23B8 File Offset: 0x003B05B8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("IBR:IBFTN", this.a);
	}

	// Token: 0x17000286 RID: 646
	// (get) Token: 0x060097C0 RID: 38848 RVA: 0x003B23D4 File Offset: 0x003B05D4
	// (set) Token: 0x060097C1 RID: 38849 RVA: 0x003B23DC File Offset: 0x003B05DC
	public string ItemBlueprintFullTypeName
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

	// Token: 0x060097C2 RID: 38850 RVA: 0x003B23E8 File Offset: 0x003B05E8
	public bdc()
	{
	}

	// Token: 0x060097C3 RID: 38851 RVA: 0x003B23F0 File Offset: 0x003B05F0
	public bdc(Type A_0)
	{
		czh.a(A_0, "itemBlueprintType");
		this.a = d79.a(A_0);
	}

	// Token: 0x060097C4 RID: 38852 RVA: 0x003B2410 File Offset: 0x003B0610
	public bdc(string A_0)
	{
		czh.a(A_0, "itemBlueprintFullTypeName");
		this.a = A_0;
	}

	// Token: 0x060097C5 RID: 38853 RVA: 0x003B242C File Offset: 0x003B062C
	public bdc(cwp A_0)
	{
		czh.a(A_0, "itemBlueprint");
		this.a = d79.a(A_0.GetType());
		base.a(A_0);
	}

	// Token: 0x060097C6 RID: 38854 RVA: 0x003B2458 File Offset: 0x003B0658
	protected override cwp h4()
	{
		return d79.a(this.a);
	}

	// Token: 0x060097C7 RID: 38855 RVA: 0x003B2468 File Offset: 0x003B0668
	public bdc b()
	{
		return new bdc(this.a);
	}

	// Token: 0x04003A4C RID: 14924
	private string a;
}
