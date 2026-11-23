using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020007BB RID: 1979
[eiz("SGSCIOA")]
[Serializable]
public sealed class d5k : esc, ISerializable
{
	// Token: 0x0600318B RID: 12683 RVA: 0x0012F830 File Offset: 0x0012DA30
	private d5k(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600318C RID: 12684 RVA: 0x0012F840 File Offset: 0x0012DA40
	public override int d5(bq8 A_0, bq8 A_1)
	{
		HashSet<string> classPropertyValue = A_1.GetClassPropertyValue<HashSet<string>>("clueList");
		string classPropertyValue2 = A_1.GetClassPropertyValue<string>("suspect");
		string value = "notConvinced";
		if (classPropertyValue != null && !string.IsNullOrEmpty(classPropertyValue2))
		{
			if (!(classPropertyValue2 == "pasquale"))
			{
				if (!(classPropertyValue2 == "bigBret"))
				{
					if (!(classPropertyValue2 == "mordre"))
					{
						if (!(classPropertyValue2 == "quinton"))
						{
						}
					}
					else if (classPropertyValue.Contains("M5"))
					{
						value = "guilty";
					}
					else if (classPropertyValue.Contains("M1") && classPropertyValue.Contains("M2") && classPropertyValue.Contains("G1") && classPropertyValue.Contains("G2") && ((classPropertyValue.Contains("M3") && classPropertyValue.Contains("M6")) || classPropertyValue.Contains("M4")))
					{
						value = "guilty";
					}
				}
				else if (classPropertyValue.Contains("B1") && classPropertyValue.Contains("B2") && ((classPropertyValue.Contains("G1") && classPropertyValue.Contains("G2")) || classPropertyValue.Contains("B3") || classPropertyValue.Contains("B4") || classPropertyValue.Contains("B5")))
				{
					value = "guilty";
				}
			}
			if (classPropertyValue.Contains("Q4") && classPropertyValue2 == "pasquale")
			{
				value = "evidenceConflict";
			}
			if (this.a(classPropertyValue, new string[]
			{
				"F1",
				"F2",
				"F3",
				"F5",
				"F6"
			}) || this.a(classPropertyValue, new string[]
			{
				"G1",
				"F1"
			}) || this.a(classPropertyValue, new string[]
			{
				"G1",
				"F3"
			}) || this.a(classPropertyValue, new string[]
			{
				"G1",
				"F5"
			}) || this.a(classPropertyValue, new string[]
			{
				"G1",
				"F6"
			}))
			{
				value = "evidenceConflict";
			}
			if (classPropertyValue.Count > 7)
			{
				value = "evidenceOverload";
			}
			HashSet<string> hashSet = new HashSet<string>();
			hashSet.Add("P");
			hashSet.Add("B");
			hashSet.Add("Q");
			hashSet.Add("M");
			HashSet<string> hashSet2 = new HashSet<string>();
			foreach (string text in classPropertyValue)
			{
				if (!string.IsNullOrEmpty(text))
				{
					string text2 = text.Substring(0, 1);
					if (hashSet.Contains(text2))
					{
						hashSet2.Add(text2);
					}
				}
			}
			if (hashSet2.Count > 1)
			{
				value = "evidenceOverload";
			}
		}
		A_1.set_Item("outcome", value);
		return 0;
	}

	// Token: 0x0600318D RID: 12685 RVA: 0x0012FB9C File Offset: 0x0012DD9C
	private bool a(HashSet<string> A_0, params string[] A_1)
	{
		bool flag = false;
		foreach (string text in A_1)
		{
			if (A_0.Contains(text))
			{
				if (flag)
				{
					return true;
				}
				flag = true;
			}
		}
		return false;
	}

	// Token: 0x0600318E RID: 12686 RVA: 0x0012FBE0 File Offset: 0x0012DDE0
	public d5k()
	{
	}
}
