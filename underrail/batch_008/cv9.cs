using System;
using System.Runtime.Serialization;

// Token: 0x02001925 RID: 6437
[eiz("CI2")]
[Serializable]
public class cv9 : dj3, ISerializable
{
	// Token: 0x060088A4 RID: 34980 RVA: 0x003883F4 File Offset: 0x003865F4
	protected cv9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(cv9);
		}
	}

	// Token: 0x060088A5 RID: 34981 RVA: 0x00388420 File Offset: 0x00386620
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060088A6 RID: 34982 RVA: 0x0038842C File Offset: 0x0038662C
	public override string tv()
	{
		return "Расходный";
	}

	// Token: 0x060088A7 RID: 34983 RVA: 0x00388438 File Offset: 0x00386638
	public override bk3 tw()
	{
		cv9 cv = new cv9();
		this.ai7(cv);
		return cv;
	}

	// Token: 0x060088A8 RID: 34984 RVA: 0x00388454 File Offset: 0x00386654
	public cv9()
	{
	}
}
