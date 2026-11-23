using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

// Token: 0x02001BF2 RID: 7154
[TypeConverter(typeof(bf7))]
[eiz("WSD")]
[Serializable]
public struct q5 : ISerializable
{
	// Token: 0x06009BD9 RID: 39897 RVA: 0x003D1D04 File Offset: 0x003CFF04
	private q5(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (A_0.GetValue("S", typeof(double?)) as double?);
		this.b = (A_0.GetValue("T", typeof(int?)) as int?);
	}

	// Token: 0x06009BDA RID: 39898 RVA: 0x003D1D5C File Offset: 0x003CFF5C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("S", this.a);
		info.AddValue("T", this.b);
	}

	// Token: 0x06009BDB RID: 39899 RVA: 0x003D1D8C File Offset: 0x003CFF8C
	public q5(double? A_0, int? A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06009BDC RID: 39900 RVA: 0x003D1DA0 File Offset: 0x003CFFA0
	public override string ToString()
	{
		return string.Format("{0}/{1}", (this.a != null) ? this.a.Value.ToString() : "", (this.b != null) ? this.b.Value.ToString() : "");
	}

	// Token: 0x06009BDD RID: 39901 RVA: 0x003D1E14 File Offset: 0x003D0014
	public static q5 a(string A_0)
	{
		if (!string.IsNullOrEmpty(A_0))
		{
			string[] array = A_0.Split(new string[]
			{
				"/"
			}, StringSplitOptions.RemoveEmptyEntries);
			if (array.Length == 2)
			{
				double value;
				double.TryParse(array[0].Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out value);
				int value2;
				int.TryParse(array[1].Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out value2);
				return new q5(new double?(value), new int?(value2));
			}
		}
		return default(q5);
	}

	// Token: 0x04003BB1 RID: 15281
	public double? a;

	// Token: 0x04003BB2 RID: 15282
	public int? b;
}
