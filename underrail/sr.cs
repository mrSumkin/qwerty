using System;

// Token: 0x02001D06 RID: 7430
public sealed class sr : apq
{
	// Token: 0x0600A35E RID: 41822 RVA: 0x003EADA8 File Offset: 0x003E8FA8
	public override Type e3()
	{
		return typeof(q1);
	}

	// Token: 0x0600A35F RID: 41823 RVA: 0x003EADB4 File Offset: 0x003E8FB4
	public override string e4()
	{
		return "BulletTime";
	}

	// Token: 0x0600A360 RID: 41824 RVA: 0x003EADBC File Offset: 0x003E8FBC
	public override string e5()
	{
		return "Время пули";
	}

	// Token: 0x0600A361 RID: 41825 RVA: 0x003EADC4 File Offset: 0x003E8FC4
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A362 RID: 41826 RVA: 0x003EADC8 File Offset: 0x003E8FC8
	public override object[] e7()
	{
		return new object[]
		{
			Convert.ToInt32(sr.a * 100.0)
		};
	}

	// Token: 0x04003E5F RID: 15967
	public new static readonly double a = 0.04;
}
