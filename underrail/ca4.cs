using System;
using System.ComponentModel;
using System.Runtime.Serialization;

// Token: 0x02000FFA RID: 4090
[TypeConverter(typeof(bf7))]
[eiz("RGCS")]
[Serializable]
public struct ca4 : ISerializable
{
	// Token: 0x06005426 RID: 21542 RVA: 0x00254080 File Offset: 0x00252280
	private ca4(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetBoolean("RGCS:E");
		this.b = A_0.GetString("RGCS:C");
		this.c = A_0.GetInt32("RGCS:D");
	}

	// Token: 0x06005427 RID: 21543 RVA: 0x002540B8 File Offset: 0x002522B8
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("RGCS:E", this.a);
		info.AddValue("RGCS:C", this.b);
		info.AddValue("RGCS:D", this.c);
	}

	// Token: 0x06005428 RID: 21544 RVA: 0x002540F0 File Offset: 0x002522F0
	public static ca4 a(string A_0)
	{
		if (!string.IsNullOrEmpty(A_0))
		{
			string[] array = A_0.Split(new char[]
			{
				','
			});
			if (array.Length >= 2)
			{
				string text = array[0].Trim();
				int num;
				if (int.TryParse(array[1].Trim(), out num))
				{
					return new ca4
					{
						a = true,
						b = text,
						c = num
					};
				}
			}
		}
		return default(ca4);
	}

	// Token: 0x06005429 RID: 21545 RVA: 0x00254174 File Offset: 0x00252374
	public override string ToString()
	{
		if (this.a && !string.IsNullOrWhiteSpace(this.b))
		{
			return this.b + ", " + this.c.ToString();
		}
		return "Нет";
	}

	// Token: 0x0400225F RID: 8799
	public bool a;

	// Token: 0x04002260 RID: 8800
	public string b;

	// Token: 0x04002261 RID: 8801
	public int c;
}
