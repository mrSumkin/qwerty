using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

// Token: 0x020000EF RID: 239
[eiz("SCS")]
[TypeConverter(typeof(bf7))]
[Serializable]
public class ayb : bjp, ISerializable
{
	// Token: 0x06000574 RID: 1396 RVA: 0x00017D78 File Offset: 0x00015F78
	protected ayb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06000575 RID: 1397 RVA: 0x00017D84 File Offset: 0x00015F84
	public ayb()
	{
	}

	// Token: 0x06000576 RID: 1398 RVA: 0x00017D8C File Offset: 0x00015F8C
	public override void s3(byte A_0)
	{
		bcj.c(A_0);
		if (!this.b.Contains(A_0))
		{
			this.c = false;
		}
		this.b.Add(A_0);
	}

	// Token: 0x06000577 RID: 1399 RVA: 0x00017DB8 File Offset: 0x00015FB8
	public override void s4(byte A_0)
	{
		if (this.b.Remove(A_0) && !this.b.Contains(A_0))
		{
			this.c = false;
		}
	}

	// Token: 0x06000578 RID: 1400 RVA: 0x00017DE8 File Offset: 0x00015FE8
	protected override object s5()
	{
		ayb ayb = new ayb();
		foreach (byte a_ in this.b)
		{
			ayb.s3(a_);
		}
		return ayb;
	}

	// Token: 0x06000579 RID: 1401 RVA: 0x00017E48 File Offset: 0x00016048
	public new static ayb a(string A_0)
	{
		string[] array = A_0.Split(new char[]
		{
			','
		});
		ayb ayb = new ayb();
		foreach (string s in array)
		{
			try
			{
				byte a_ = byte.Parse(s, CultureInfo.InvariantCulture);
				ayb.s3(a_);
			}
			catch
			{
			}
		}
		return ayb;
	}
}
