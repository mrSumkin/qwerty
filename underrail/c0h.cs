using System;
using System.Runtime.Serialization;

// Token: 0x020019D4 RID: 6612
[eiz("NWCME")]
[Serializable]
public sealed class c0h : cdh, ISerializable, d7s
{
	// Token: 0x06008DC2 RID: 36290 RVA: 0x00394098 File Offset: 0x00392298
	private c0h(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008DC3 RID: 36291 RVA: 0x003940A4 File Offset: 0x003922A4
	public override bool ae5()
	{
		return true;
	}

	// Token: 0x06008DC4 RID: 36292 RVA: 0x003940A8 File Offset: 0x003922A8
	public c0h()
	{
	}

	// Token: 0x06008DC5 RID: 36293 RVA: 0x003940B0 File Offset: 0x003922B0
	public override string b2()
	{
		return "Нельзя нанести критический удар оружием или безоружными атаками.";
	}

	// Token: 0x06008DC6 RID: 36294 RVA: 0x003940BC File Offset: 0x003922BC
	public override d3e b3()
	{
		c0h c0h = new c0h();
		this.xx(c0h);
		return c0h;
	}

	// Token: 0x06008DC7 RID: 36295 RVA: 0x003940D8 File Offset: 0x003922D8
	public void cn(d3e A_0)
	{
	}

	// Token: 0x06008DC8 RID: 36296 RVA: 0x003940DC File Offset: 0x003922DC
	public bool co(d3e A_0)
	{
		return A_0 is c0h;
	}
}
