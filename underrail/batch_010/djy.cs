using System;
using System.Runtime.Serialization;

// Token: 0x02001AB6 RID: 6838
[eiz("XSCSE")]
[Serializable]
public sealed class djy : els, ISerializable
{
	// Token: 0x06009449 RID: 37961 RVA: 0x003A5DD4 File Offset: 0x003A3FD4
	private djy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600944A RID: 37962 RVA: 0x003A5DE0 File Offset: 0x003A3FE0
	public override bool sk()
	{
		return false;
	}

	// Token: 0x0600944B RID: 37963 RVA: 0x003A5DE4 File Offset: 0x003A3FE4
	public djy() : base(djy.a, "systemCharred", ci8.c)
	{
		base.Duration = 0;
		base.Icon = "Misc.0";
		base.VisualEffects.Add(new ud(this, "Charred"));
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		base.Silent = true;
	}

	// Token: 0x0600944C RID: 37964 RVA: 0x003A5E40 File Offset: 0x003A4040
	public override string cb(ll A_0)
	{
		return "";
	}

	// Token: 0x04003907 RID: 14599
	public new static readonly string a = "systemCharred";
}
