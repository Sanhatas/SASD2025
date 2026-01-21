# **Homework 1: เลือกฟังคลิปแล้วสรุปเนื้อหา**

## **Name and ID:**

- **Name:**  นายสัณหธรรศน์ จึงธีรพานิช
- **ID:**    66102010154

## **Summary Content:**

### **Software Design:**

```Eng Version```

Software design isn't just about code. it's an exercise in **human relationships.** 

Beck introduces the concepts of **"Waiter"** (thoe who need a feature) and **"Changers"** (those who implement it). The tension in software development often arises from the diverging incentives between these two groups. Waiters want features quickly, while Changers want a clean structure to work with. Proper design help maintain trust and psychological safety between these parties.

```Thai Version```

Software Design ไม่ใช่แค่เรื่องของโค้ด แต่เป็นเรื่องของ **ความสัมพันธ์** (humam relationships)

Beck มองว่า Software ประกอบด้วยคน 2 กลุ่มคือ **"Waiters"** (ผู้รอ) ซึ่งคือฝ่ายธุรกิจหรือลูกค้าที่ต้องการ feature ใหม่ ๆ และ **""Changers"** (Programmer) หรือคือ Software Developer ที่ต้องแก้ไขโค้ด โดยปัญหาใหญ่ของการทำ Software มักเกิดจาก **"ความเชื่อใจ"** (Trust) ลดลง เมื่อ Waiters หรือฝ่ายธุรกิจต้องการงานเร็วแต่โปรแกรมเมอร์ทำไม่ได้เนื่องจากโครงสร้างของโค้ดไม่เอื้อต่อการทำงานให้เสร็จได้โดยไว การออกแบบที่ดีจึงจะเข้รมาช่วยให้ทำให้สภาพแวดล้อมการทำงานของทั้ง Waiters และ Changers ทำงานร่วมกันได้อย่างราบลื่นมากยิ่งขึ้น

### **Cost of software**

```Eng Version```

Why software is expensive. He references **Constantine's Equivalence**, which states that the total cost of software is roughly equal to the cost of making chagrs, which in turn is driven by the cost of **"Big changes."** He explains the **Coupling**-the degree to which different parts of the code depend on each other-is the primary driver of rhese costs. If code is highly coupled, a small change can trigger a **"cascading"** effect (like a snow avalanche), making development unpredictable and expensive

The Strategy of **"Tidying"**

To manage these costs, Beck suggests **Tidying**-small, low-risk structural changes (refactorings) performed right before implementing a new behavior. This approach reduces coupling and makes the actual feature implementation **"dead simple"**, there by lowering the overall cost and risk.

```Thai Version```

ทำไม Software ถึงมีราคาแพง อ้างอิงถึงสมการของ **Constantine** (Constantine's Equivalence) ซึ่งสรุปได้ว่า **ต้นทุนรวมของซอฟต์แวร์ ≈ ต้นทุนของการเปลี่ยนแปลง ≈ ต้นทุนของการเปลี่ยนแปลงครั้งใหญ่ ≈ Coupling** หมายความว่ายิ่งโค้ดมีส่วนต่าง ๆ ของโปรแกรมพึ่งพากันและกัน (Coupling) มากเท่าไหร่ ต้นทุนในการดูแลและแก้ไขจะยิ่งสูงขึ้น การเปลี่ยนแปลงโค้ดเพียงเล็กน้อยสามารถส่งผลแบบลูกโซ่ ซึ่งทำให้การพัฒนา Software ไม่สามารถคาดการณ์ได้โดยง่ายและมีราคาที่แพง

กลยุทธ์ **"Tidying"** (การจัดระเบียบ)

เพื่อจัดการกับต้นทุนเหล่านี้ Beck แนะนำแนวคิด **Tidying** (การจัดระเบียบ) ซึ่งเป็นการเปลี่ยนแปลงโครงสร้างโค้ดเล็ก ๆ น้อย ๆ ที่มีความเสี่ยงที่ต่ำ (refactorings) โดยทำทันทีก่อนที่จะเริ่มการเพิ่ม feature ใหม่ ๆ โดยวิธีการนี้จะช่วยลดการพึ่งพากันและกัน (Coupling) ของโค้ดและทำให้การเขียน feature ใหม่ ๆ จริง ๆ นั้น **"ง่ายมาก ๆ"** (dead simple) ซึ่งช่วยลดทั้งต้นทุนและความเสี่ยงในภาพรวมลงได้

## **Additional Vocabulary:**

- **Tidying:** Small, low-risk structural changes made to the code (Refactoring) right before adding a new feature. The goal is to make the code easier to understand or **cleaner** so that the next change (the new feature) becomes very simple to implement. การปรับโครงสร้างโค้ดเล็ก ๆ น้อย ๆ ให้สะอาดขึ้นก่อนที่จะเพิ่ม feature ใหม่ เพื่อให้การเพิ่ม feature นั้นทำได้ง่ายและปลอดภัย
- **Coupling:** The degree to which different parts of a software system depend on each other. การที่ส่วนต่าง ๆ ของโปรแกรมพึ่งพากันและกัน หากส่วนหนึ่งเปลี่ยน อีกส่วนต้องเปลี่ยนตาม ยิ่วมีค่านี้สูง โค้ดจะยิ่งแก้ไขยาก
- **Cohesion:** The measure of how strongly related the function or logic within a single module or class are. การที่โค้ดใน Module หรือ Class เดียวกันทำงานไปในทิศทางเดียวกันและทำหน้าที่เดียวกันอย่างชัดเจน (โค้ดที่ดีควรมี High Cohesion)
- **Constantine's Equivalence:** This implies that the total cost of software is essentially driven by the cost od making changes, and the cost of changes is driven primarily by coupling. แนวคิดที่บอกว่าต้นทุนที่แท้จริงของ Software ขึ้นอยู่กับความยากง่ายในการเปลี่ยนแปลง ซึ่งถูกกำหนดโดย Coupling

## **Reference Source:**

- [Click here to access source](https://youtu.be/Saaz6D1azlU?si=9fhnndp0M50kZHYh) (YouTube Link)
- **Time:** 23:40 - 38:05
